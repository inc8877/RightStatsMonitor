<p align="center">
  <img width="500" height="333" src="https://user-images.githubusercontent.com/29813954/115844892-f7ebb980-a428-11eb-89e4-000e60e26b45.png">
</p>

# RightStatsMonitor

Useful tool for displaying FPS with high precision. GC free

## Table of Contents

- [RightStatsMonitor](#rightstatsmonitor)
  - [Table of Contents](#table-of-contents)
  - [Installation](#installation)
    - [Install via OpenUPM](#install-via-openupm)
    - [Install via Git URL](#install-via-git-url)
  - [Small useful features](#small-useful-features)
  - [Credits](#credits)

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

## Credits

RSM logo background by [Jorge Salvador](https://unsplash.com/@jsshotz)