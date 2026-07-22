# Solaris Telemetry — Data Logger & Graph

A real‑time telemetry ground station for a solar‑powered race car. It receives live
data from the car over a **LoRa radio link**, decodes a custom binary protocol,
displays every channel on a single dashboard, plots live graphs, and logs everything
to disk for later analysis.

Built for **Solaris**, a university solar car team that competes in international
solar‑car races. This is the software the crew watches in the pit while the car is
on track — battery health, motor load, orientation, and GPS position at a glance.

![Screenshot of the telemetry dashboard](docs/solaris-telemetry.png)

---

## About this project

- **Team:** Solaris solar racing team (international solar‑car competitions).
- **Role:** telemetry / ground‑station software — receive, decode, visualize, and log
  the car's live data stream.
- **Completed:** April 2022, during my time at university.
- **Starting point:** I did **not** know C# when I began. I picked up the language,
  WinForms, and the .NET ecosystem while building this, and reverse‑engineered the
  car's radio data format from scratch.

I'm keeping this in my portfolio because it's an honest snapshot of learning a new
stack end‑to‑end under real constraints: a live radio link, an undocumented binary
protocol, and a dashboard that had to be readable at a glance during a race.

---

## What it does

Decodes and displays **90 telemetry channels** in real time from a single radio link:

- **Receives telemetry over LoRa** through a serial (COM) port and decodes it in real time.
- **Battery pack monitoring** — **32 cell voltages** (across four BMS banks) and
  **30 pack temperatures**.
- **Power & drivetrain** — battery/PV energy, current and voltage, vehicle speed,
  cabin temperature, and computed motor current.
- **Orientation & position (IMU & GPS)** — yaw / pitch / roll, gyroscope and
  accelerometer axes, latitude / longitude, GPS speed and altitude.
- **Component temperatures** — MPPTs, motors, and PV, plus a pilot‑warning flag.
- **Live graphs** — scrolling Motor Speed and Motor Current charts with selectable
  time windows (1 / 5 / 10 / 15 min / infinite) and a reset.
- **CSV data logging** — while connected, every telemetry channel is logged to a
  timestamped **`.csv`** file (see below), ready for analysis in Excel / pandas.
- **Responsive UI** — the whole dashboard auto‑scales to fill any window size.

### Data logging (CSV)

On **Connect**, the app opens a new file `Log/telemetry_YYYY-MM-DD_HH-MM-SS.csv` next to
the executable and writes a header row of all channel names. It then appends one row every
**500 ms** — a `Timestamp` column followed by all **90 telemetry channels** (91 columns
total) — and closes the file on **Disconnect**. Values use invariant formatting (`.` decimal
separator), so the files open cleanly in any spreadsheet or data tool.

---

## The LoRa telemetry protocol (reverse‑engineered)

The car's radio firmware wasn't documented, so the wire format here was recovered by
inspecting the raw byte stream. Each frame is a fixed binary packet:

| Field | Offset | Notes |
|------|--------|-------|
| Start byte | `0` | `:` (`0x3A`) — frames are re‑synced to this marker |
| Channel / type | `1`, `4` | byte `[1]` = `'A'`/`'B'` for temperature / IMU‑GPS frames; byte `[4]` selects the module: `6` = main module, `70/72/74/76` = BMS banks 1–4 |
| Payload | `2 … 33` | little‑endian 16‑bit values; most are transmitted ×10 and divided back on display |
| **CRC** | `34` | `sum(bytes[0..33]) mod 256` — a simple custom checksum |
| Extended payload + CRC | `35 … 42` | `'A'`/`'B'` frames carry extra fields with a second checksum at byte `42` |

A **basic custom CRC** (modulo‑256 additive checksum) guards every frame; a packet is
only applied to the UI once its checksum matches, so corrupted radio frames are dropped.
The receiver reads bytes off the serial port, realigns to the `:` start marker, validates
the checksum, dispatches by channel, and updates the corresponding dashboard fields.

---

## Tech stack

- **Language:** C# (.NET Framework 4.7.2)
- **UI:** Windows Forms, with **WPF‑hosted** live charts via [LiveCharts](https://lvcharts.com/) (`LiveCharts.WinForms` / `LiveCharts.Wpf`)
- **I/O:** `System.IO.Ports.SerialPort` for the LoRa link; [CsvHelper](https://joshclose.github.io/CsvHelper/) for data handling
- **Tooling:** Visual Studio, NuGet

---

## Project structure

```
Telemetri Data Logger and Graph/
├── Program.cs                 # entry point
├── Form1.cs                   # UI logic + LoRa frame decoding & CRC
├── Form1.Designer.cs          # dashboard layout (auto‑generated)
├── DataClass.cs               # telemetry data model
├── MeasureModel.cs            # chart data point (time, value)
├── ZoomingAndPanning.cs       # chart interaction helpers
└── packages.config            # NuGet dependencies
```

---

## Build & run (Windows)

1. Open `Telemetri Data Logger and Graph.sln` in **Visual Studio** (2019+).
2. Restore NuGet packages (automatic on first build, or `nuget restore`).
3. Build & run (**F5**).
4. Click **Scan Port**, choose the COM port of your LoRa receiver, pick a baud rate,
   and press **Connect**.

Requires the **.NET Framework 4.7.2** developer pack.

---

## Testing without hardware

You don't need the car (or a LoRa radio) to try the interface. This repo includes
a Python emulator, **`telemetry_test_sender.py`**, that speaks the same binary
protocol over a virtual serial port and streams realistic, checksum‑valid frames —
animated speed/current, battery cells, temperatures, IMU and GPS.

```bash
python3 telemetry_test_sender.py --com 5
# then in the app: Scan Port → COM5 → Baud → Connect
```

See the header of `telemetry_test_sender.py` for the full protocol notes and options
(`--once`, `--interval`, `--com`).

---

## Running on Linux (optional)

Although this is a Windows (.NET Framework + WPF) application, it also runs on Linux
through **Wine**. A helper script, `linux-build-run.sh`, restores packages, builds with
the in‑prefix MSBuild, and launches the app:

```bash
./linux-build-run.sh          # restore + build + run
```

A working serial link under Wine needs a virtual port that provides modem‑control lines
(a plain `socat` pty is not enough) — [`tty0tty`](https://github.com/freemed/tty0tty)
works well and is auto‑detected by the test sender.

---

## Notes

- The user interface is fully in **English**. Some of the original **source‑code
  comments** are still in Turkish (the team's working language) and are left as‑is as
  part of the project's history.
- The custom CRC is intentionally simple (modulo‑256 additive) — it matched what the
  car's radio firmware produced and was enough to reject corrupted frames over the link.

---

## Author

Co-developed with a teammate for the Solaris solar racing team, April 2022.
