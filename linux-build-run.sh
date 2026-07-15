#!/usr/bin/env bash
# Build & run "Telemetri Data Logger and Graph" (.NET Framework 4.7.2 WinForms+WPF) on Linux via Wine.
#
# One-time setup (already done once, safe to re-run — installs .NET 4.7.2 into a dedicated Wine prefix):
#   WINEPREFIX="$HOME/.local/share/wineprefixes/telemetri" WINEARCH=win64 winetricks -q dotnet472
#
# Usage:
#   ./linux-build-run.sh              # restore (if needed) + build Release + run
#   ./linux-build-run.sh build        # build only
#   ./linux-build-run.sh run          # run last build only
#   ./linux-build-run.sh restore      # (re)download NuGet packages only
set -euo pipefail

export WINEPREFIX="$HOME/.local/share/wineprefixes/telemetri"
export WINEARCH=win64
export WINEDEBUG=-all
: "${DISPLAY:=:1}"; export DISPLAY

REPO="$(cd "$(dirname "${BASH_SOURCE[0]}")" && pwd)"
PROJDIR="$REPO/Telemetri Data Logger and Graph"
CSPROJ="$PROJDIR/Telemetri Data Logger and Graph.csproj"
PKGDIR="$REPO/packages"
MSBUILD="$WINEPREFIX/drive_c/windows/Microsoft.NET/Framework64/v4.0.30319/MSBuild.exe"
EXE="$PROJDIR/bin/Release/Telemetri Data Logger and Graph.exe"

restore() {
  echo ">> Restoring NuGet packages into $PKGDIR"
  mkdir -p "$PKGDIR"
  local pkgs="CsvHelper:27.2.1 LiveCharts:0.9.7 LiveCharts.WinForms:0.9.7.1 LiveCharts.Wpf:0.9.7 \
    Microsoft.Bcl.AsyncInterfaces:6.0.0 Microsoft.Bcl.HashCode:1.1.1 Microsoft.CSharp:4.7.0 \
    System.Buffers:4.5.1 System.Memory:4.5.4 System.Numerics.Vectors:4.5.0 \
    System.Runtime.CompilerServices.Unsafe:6.0.0 System.Threading.Tasks.Extensions:4.5.4"
  local tmp; tmp="$(mktemp -d)"
  for p in $pkgs; do
    local id="${p%%:*}" ver="${p##*:}"; local lid; lid="$(echo "$id" | tr '[:upper:]' '[:lower:]')"
    local dest="$PKGDIR/$id.$ver"
    [ -d "$dest" ] && { echo "   have $id.$ver"; continue; }
    curl -sL -o "$tmp/x.nupkg" "https://api.nuget.org/v3-flatcontainer/$lid/$ver/$lid.$ver.nupkg"
    mkdir -p "$dest" && unzip -oq "$tmp/x.nupkg" -d "$dest" && echo "   got  $id.$ver"
  done
  rm -rf "$tmp"
}

build() {
  [ -d "$PKGDIR/LiveCharts.0.9.7" ] || restore
  echo ">> Building (Release)"
  wine "$MSBUILD" "$CSPROJ" /p:Configuration=Release /p:Platform=AnyCPU /v:minimal /nologo
  echo ">> Built: $EXE"
}

run() {
  [ -f "$EXE" ] || build
  echo ">> Launching app"
  cd "$(dirname "$EXE")"
  exec wine "$(basename "$EXE")"
}

case "${1:-all}" in
  restore) restore ;;
  build)   build ;;
  run)     run ;;
  all)     build; run ;;
  *) echo "usage: $0 [all|build|run|restore]"; exit 1 ;;
esac
