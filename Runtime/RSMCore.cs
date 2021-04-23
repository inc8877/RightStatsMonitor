using System.Diagnostics;
using TMPro;
using UnityEngine;
using UnityEngine.Profiling;

namespace RightStatsMonitor.Core
{
    public class RSMCore : MonoBehaviour
    {
        public int targetFPS = 120;
        [Tooltip("in milliseconds")] public long fpsUpdateTime = 500;
        [Tooltip("in seconds")] public float RAMUpdateTime = 1f;
        public TMP_Text fpsText, allocatedRamText, reservedRamText, monoRamText;
        
        public static float CurrentFPS { get; private set; }

        private Stopwatch _stopwatch;
    
        private int _passedFrames;
        private long _passedMilliseconds;
        private float _passedSeconds, _currentFrameTime, _timeCount = 1f;
    

        private void Start()
        {
            QualitySettings.vSyncCount = 0;
            Application.targetFrameRate = targetFPS;
        
            _stopwatch = Stopwatch.StartNew();
        }

        private void Update()
        {
            if (_timeCount >= RAMUpdateTime)
            {
                _timeCount = 0f;
                allocatedRamText.SetText("Allocated: {0:1}", Profiler.GetTotalAllocatedMemoryLong()/ 1048576f);
                reservedRamText.SetText("Reserved: {0:1}", Profiler.GetTotalReservedMemoryLong() / 1048576f);
                monoRamText.SetText("Mono: {0:1}", Profiler.GetMonoUsedSizeLong() / 1048576f);
            }
            else _timeCount += Time.deltaTime;

            _passedFrames++;

            _passedMilliseconds = _stopwatch.ElapsedMilliseconds;
        
            if (_passedMilliseconds < fpsUpdateTime) return;

            _passedSeconds = _passedMilliseconds / 1000f;

            CurrentFPS = _passedFrames / _passedSeconds;
            _currentFrameTime = _passedMilliseconds / (float)_passedFrames;

            fpsText.SetText("FPS: {0:1} (ms {1:1})", CurrentFPS, _currentFrameTime);

            _passedFrames = 0;
            _stopwatch.Restart();
        }
    }
}
