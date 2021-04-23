# RightStatsMonitor

High FPS accuracy and GC free

## Installation

### Install via OpenUPM

The package is available on the [openupm](https://openupm.com) registry. It's recommended to install it via [openupm-cli](https://github.com/openupm/openupm-cli).

```c#
openupm add com.inc8877.right-stats-monitor
```

### Install via Git URL

Open `Packages/manifest.json` with your favorite text editor. Add the following line to the dependencies block.

```c#
{
  "dependencies": {
    "com.inc8877.right-stats-monitor": "https://github.com/inc8877/RightStatsMonitor.git",
   }
}
```

## Small useful features

```c#
using RightStatsMonitor.Core;

// Get current FPS
RSMCore.CurrentFPS
```
