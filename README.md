<p align="center">
  <img width="500" height="333" src="https://user-images.githubusercontent.com/29813954/115844892-f7ebb980-a428-11eb-89e4-000e60e26b45.png">
</p>

# RightStatsMonitor

[![openupm](https://img.shields.io/npm/v/com.inc8877.right-stats-monitor?label=openupm&registry_uri=https://package.openupm.com)](https://openupm.com/packages/com.inc8877.right-stats-monitor/)

Useful tool for displaying FPS with high precision. Very lightweight and fast. GC-free

## Table of Contents

- [RightStatsMonitor](#rightstatsmonitor)
  - [Table of Contents](#table-of-contents)
  - [Demonstration](#demonstration)
  - [How to use](#how-to-use)
  - [Installation](#installation)
    - [Install via OpenUPM](#install-via-openupm)
    - [Install via Git URL](#install-via-git-url)
  - [Small useful features](#small-useful-features)
  - [Notes](#notes)
  - [Credits](#credits)

## Demonstration

<p align="center">
  <img src="https://imgur.com/epAGaOK.gif">
</p>

## How to use

1. [Install](#installation) `RSM`
2. Use available actions to interact with the `RSM` via `Tools > RightStatsMonitor`

The `RSM` has global settings like target frame rate, canvas sort order, initialize at startup, and more.
You can customize the way you want, to do this, just open the settings under this path `Tools> RightStatsMonitor> Preferences`.

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

## Notes

RSM may allocate some memory at runtime in Editor. At runtime on platforms (iOS, Android) does not allocate memory. This has to do with how TMP works in the editor. [[Explanation](https://forum.unity.com/threads/runtime-allocation-and-huge-cpu-usage.564175/)]

## Credits

RSM logo background by [Jorge Salvador](https://unsplash.com/@jsshotz)
