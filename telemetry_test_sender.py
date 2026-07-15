#!/usr/bin/env python3
"""
Telemetry test data sender for "Telemetri Data Logger and Graph".

It emulates the LoRa/serial device the app expects, so you can exercise the
whole UI (battery voltages/temps, IMU/GPS, motor temps) and watch the two
LiveCharts graphs (Motor Speed / Motor Current) animate — with no hardware.

WHAT IT DOES
  1. Creates a virtual serial port pair with `socat` (one end for the app,
     one for this script).
  2. Wires the app-side end into the Wine prefix as COMn and registers it so
     it shows up in the program's "Scan Port" list.
  3. Streams protocol frames (parsed by Form1.cs) until you press Ctrl+C.

USAGE
  python3 telemetry_test_sender.py            # defaults: COM5, live animated data
  python3 telemetry_test_sender.py --com 6    # use a different COM number
  python3 telemetry_test_sender.py --once     # send one of every frame and exit

THEN, in the running app:
  Scan Port  ->  pick COM5  ->  Baud Rate: 115200  ->  Connect.
  (Baud value is irrelevant for a virtual port — any selection works.)

PROTOCOL (reverse-engineered from Form1.cs)
  Every frame: byte[0]=':' (0x3A). Length >= 37 bytes; we send 43.
  Main checksum: byte[34] = sum(bytes[0..33]) & 0xFF   (required for the UI to
                 refresh — Yazdir() only runs when this matches).
  'A'/'B' frames also need: byte[42] = sum(bytes[0..41]) & 0xFF.
  16-bit fields are little-endian; the app divides most by 10.
  Channel selector is byte[4] (== 6 main module, 70/72/74/76 = BMS banks);
  battery-temp / IMU-GPS frames are flagged by byte[1] == 'A' / 'B'.
"""

import argparse
import atexit
import math
import os
import shutil
import struct
import subprocess
import sys
import time

# ---------------------------------------------------------------------------
# Config / paths
# ---------------------------------------------------------------------------
WINEPREFIX = os.environ.get(
    "WINEPREFIX", os.path.expanduser("~/.local/share/wineprefixes/telemetri")
)
LINK_DIR = os.path.expanduser("~/.cache/telemetri-serial")
APP_LINK = os.path.join(LINK_DIR, "app")   # app (Wine/COMn) side
PY_LINK = os.path.join(LINK_DIR, "py")     # this-script side

START = 0x3A          # ':'
FRAME_LEN = 43        # >= 37 required; 43 covers the 'A'/'B' byte[42] checksum


# ---------------------------------------------------------------------------
# Frame construction helpers
# ---------------------------------------------------------------------------
def put16(buf, off, value):
    """Little-endian unsigned 16-bit (matches msb_lsb_düzenleme / ToInt16)."""
    struct.pack_into("<H", buf, off, value & 0xFFFF)


def put32(buf, off, value):
    struct.pack_into("<i", buf, off, int(value))


def main_crc(buf):
    buf[34] = sum(buf[0:34]) & 0xFF


def ek_crc(buf):
    buf[42] = sum(buf[0:42]) & 0xFF


def frame_main(speed, batt_current, pv_current,
               batt_energy, pv_energy, batt_voltage, cabin_temp):
    """Channel 6 - main module. Drives Speed + Motor Current charts.
    All numeric args are in real units; the app divides by 10, so we *10 here.
    Motor Current shown by the app = batt_current + pv_current."""
    b = bytearray(FRAME_LEN)
    b[0] = START
    b[1] = 0x00                     # not 'A'/'B' -> skip Ek_Veri
    b[4] = 6                        # channel / rf_id low byte
    b[5] = 0
    put16(b, 6, int(batt_energy * 10))
    put16(b, 10, int(pv_energy * 10))
    put16(b, 12, int(batt_current * 10))
    put16(b, 14, int(pv_current * 10))
    put16(b, 16, int(batt_voltage * 10))
    put16(b, 18, int(speed * 10))
    put16(b, 20, int(cabin_temp * 10))
    main_crc(b)
    return b


def frame_imu_gps(yaw, pitch, roll, gx, gy, gz, ax, ay, az,
                  lat, lon, gps_speed, gps_height,
                  mppt1, mppt2, motor1, motor2, pv1, pv2):
    """'B' frame - IMU, GPS and motor/MPPT/PV temperatures."""
    b = bytearray(FRAME_LEN)
    b[0] = START
    b[1] = ord('B')
    put32(b, 2, lat * 1_000_000)    # Enlem  (÷1e6 in app)
    put32(b, 6, lon * 1_000_000)    # Boylam
    b[10] = gps_speed & 0xFF
    put16(b, 11, int(gps_height))
    put16(b, 13, int(yaw * 10))     # app: signed, ÷10
    put16(b, 15, int(pitch * 10))
    put16(b, 17, int(roll * 10))
    put16(b, 19, int(gx * 10))
    put16(b, 21, int(gy * 10))
    put16(b, 23, int(gz * 10))
    put16(b, 25, int(ax * 10))
    put16(b, 27, int(ay * 10))
    put16(b, 29, int(az * 10))
    b[30] = mppt1 & 0xFF            # note: app reads temps as raw bytes here
    b[31] = mppt2 & 0xFF
    b[32] = motor1 & 0xFF
    b[33] = motor2 & 0xFF
    b[35] = pv1 & 0xFF
    b[36] = pv2 & 0xFF
    main_crc(b)                    # byte[34] (also read as Motor_temp3 by app)
    ek_crc(b)
    return b


def frame_batt_temps(temps):
    """'A' frame - up to 29 battery temperatures (°C), stored as raw bytes."""
    b = bytearray(FRAME_LEN)
    b[0] = START
    b[1] = ord('A')
    for i, t in enumerate(temps[:29]):
        b[2 + i] = int(t) & 0xFF   # battery_temp1..29 -> bytes 2..30
    main_crc(b)
    ek_crc(b)
    return b


def frame_bms(channel, cell_voltage=3.70):
    """BMS bank frame (channel 70/72/74/76). Fills cell voltage slots
    (offsets 8..22, ÷100 in app) so the Battery Voltages panel populates."""
    b = bytearray(FRAME_LEN)
    b[0] = START
    b[1] = 0x00
    b[4] = channel
    b[5] = 0
    for off in range(8, 24, 2):
        put16(b, off, int(cell_voltage * 100))
    main_crc(b)
    return b


# ---------------------------------------------------------------------------
# Virtual serial + Wine wiring
# ---------------------------------------------------------------------------
def setup_virtual_serial(com_num):
    """Return (py_device, app_device). Prefers a tty0tty null-modem pair
    (/dev/tnt*) because Wine's .NET SerialPort.Open() queries modem-status
    (TIOCMGET), which plain socat ptys do NOT support -> "Request not
    supported". tty0tty emulates the modem lines, so the app can open it."""

    # Preferred: tty0tty virtual null-modem (provides modem-control lines).
    if os.path.exists("/dev/tnt0") and os.path.exists("/dev/tnt1"):
        app_dev, py_dev = "/dev/tnt0", "/dev/tnt1"
        if not os.access(py_dev, os.R_OK | os.W_OK):
            sys.exit(f"ERROR: no read/write access to {py_dev}. "
                     f"Fix perms, e.g.:  sudo chmod 666 /dev/tnt0 /dev/tnt1")
        _wire_wine(com_num, os.path.realpath(app_dev))
        return py_dev, app_dev

    # Fallback: socat pty pair. NOTE: the app usually CANNOT open this under
    # Wine (TIOCMGET unsupported on ptys). Install tty0tty for a real test:
    #   yay -S tty0tty   &&   sudo modprobe tty0tty
    print("WARNING: /dev/tnt* not found -> falling back to a socat pty.")
    print("         Wine's SerialPort.Open() will likely fail with")
    print("         'Request not supported' on a pty. For a working test,")
    print("         install tty0tty:  yay -S tty0tty  &&  sudo modprobe tty0tty\n")
    if not shutil.which("socat"):
        sys.exit("ERROR: socat not found. Install it (e.g. sudo pacman -S socat).")

    os.makedirs(LINK_DIR, exist_ok=True)
    for p in (APP_LINK, PY_LINK):
        try:
            os.remove(p)
        except FileNotFoundError:
            pass

    proc = subprocess.Popen(
        ["socat", "-d", "-d",
         f"pty,raw,echo=0,link={APP_LINK}",
         f"pty,raw,echo=0,link={PY_LINK}"],
        stdout=subprocess.DEVNULL, stderr=subprocess.DEVNULL,
    )
    atexit.register(proc.terminate)

    for _ in range(50):                     # wait up to 5s for both links
        if os.path.exists(APP_LINK) and os.path.exists(PY_LINK):
            break
        time.sleep(0.1)
    else:
        sys.exit("ERROR: socat did not create the pty links in time.")

    app_dev = os.path.realpath(APP_LINK)    # e.g. /dev/pts/7
    _wire_wine(com_num, app_dev)
    return PY_LINK, app_dev


def _wire_wine(com_num, app_dev):
    """Expose app_dev to Wine as COMn (dosdevices symlink + SERIALCOMM registry
    entry so the app's Scan Port list shows it)."""

    # Expose it to Wine as COMn (symlink + registry so Scan Port lists it).
    dosdev = os.path.join(WINEPREFIX, "dosdevices")
    os.makedirs(dosdev, exist_ok=True)
    com_link = os.path.join(dosdev, f"com{com_num}")
    if os.path.islink(com_link) or os.path.exists(com_link):
        os.remove(com_link)
    os.symlink(app_dev, com_link)

    env = dict(os.environ, WINEPREFIX=WINEPREFIX, WINEDEBUG="-all")
    subprocess.run(
        ["wine", "reg", "add", r"HKLM\HARDWARE\DEVICEMAP\SERIALCOMM",
         "/v", f"Serial{com_num}", "/t", "REG_SZ", "/d", f"COM{com_num}", "/f"],
        env=env, stdout=subprocess.DEVNULL, stderr=subprocess.DEVNULL,
    )


# ---------------------------------------------------------------------------
# Main
# ---------------------------------------------------------------------------
def main():
    ap = argparse.ArgumentParser(description="Telemetry test sender for the logger app.")
    ap.add_argument("--com", type=int, default=5, help="COM port number to expose (default 5)")
    ap.add_argument("--interval", type=float, default=0.04,
                    help="seconds between frames (default 0.04 = 25 Hz)")
    ap.add_argument("--once", action="store_true", help="send one of each frame then exit")
    args = ap.parse_args()

    py_dev, app_dev = setup_virtual_serial(args.com)

    print("=" * 66)
    print("  Virtual serial ready.")
    print(f"    App side : COM{args.com}   (-> {app_dev})")
    print(f"    Script   : {py_dev}")
    print()
    print("  In the app:  Scan Port  ->  COM%d  ->  Baud 115200  ->  Connect" % args.com)
    print("  (If COM%d is missing from the list, click Scan Port again, or" % args.com)
    print("   relaunch the app with ./linux-build-run.sh run and re-scan.)")
    print("=" * 66)

    fd = os.open(py_dev, os.O_RDWR | os.O_NOCTTY)

    def send(frame):
        os.write(fd, bytes(frame))

    try:
        if args.once:
            send(frame_main(45.0, 12.3, 4.1, 372.0, 88.0, 48.6, 26.5))
            time.sleep(args.interval)
            send(frame_imu_gps(12.5, -2.2, 3.1, 0.4, -0.3, 0.1, 0.02, 0.98, 0.05,
                               39.925, 32.866, 45, 850,
                               41, 39, 55, 57, 33, 34))
            time.sleep(args.interval)
            send(frame_batt_temps([25 + (i % 12) for i in range(29)]))
            for ch in (70, 72, 74, 76):
                time.sleep(args.interval)
                send(frame_bms(ch, 3.70))
            print("Sent one of every frame. Done.")
            return

        print("Streaming animated telemetry — press Ctrl+C to stop.\n")
        t0 = time.time()
        n = 0
        while True:
            t = time.time() - t0
            speed = 40 + 25 * math.sin(t * 0.4)              # 15..65 km/h
            batt_c = 10 + 6 * math.sin(t * 0.7)              # motor current driver
            pv_c = 3 + 2 * math.sin(t * 0.9 + 1.0)
            send(frame_main(speed, batt_c, pv_c,
                            batt_energy=370 + 5 * math.sin(t * 0.2),
                            pv_energy=85 + 10 * math.sin(t * 0.3),
                            batt_voltage=48.6, cabin_temp=26 + 2 * math.sin(t * 0.1)))
            time.sleep(args.interval)

            # Interleave the other frames a few times per second.
            if n % 5 == 0:
                send(frame_imu_gps(30 * math.sin(t * 0.5), -2.2 + 3 * math.sin(t * 0.6),
                                   5 * math.sin(t * 0.3), 0.4, -0.3, 0.1, 0.02, 0.98, 0.05,
                                   39.925, 32.866, int(speed), 850 + int(20 * math.sin(t)),
                                   41, 39, 55, 57, 33, 34))
                time.sleep(args.interval)
            if n % 7 == 0:
                send(frame_batt_temps([25 + (i % 15) + int(2 * math.sin(t)) for i in range(29)]))
                time.sleep(args.interval)
                for ch in (70, 72, 74, 76):
                    send(frame_bms(ch, 3.65 + 0.05 * math.sin(t + ch)))
                    time.sleep(args.interval)

            n += 1
            if n % 25 == 0:
                print(f"\r  t={t:6.1f}s  speed={speed:5.1f} km/h  "
                      f"motor_current={batt_c + pv_c:5.1f} A   frames={n}", end="")
                sys.stdout.flush()
    except KeyboardInterrupt:
        print("\nStopped.")
    finally:
        os.close(fd)


if __name__ == "__main__":
    main()
