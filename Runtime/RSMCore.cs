using System.Diagnostics;
using TMPro;
using UnityEngine;
using UnityEngine.Profiling;

namespace RightStatsMonitor.Core
{
    public sealed class RSMCore : MonoBehaviour
    {
        public static float CurrentFPS { get; private set; }
        
        public TMP_Text fpsText;
        public TMP_Text allocatedRamText;
        public TMP_Text reservedRamText;
        public TMP_Text monoRamText;
        
        [SerializeField] private Canvas canvas;
        
        private RsmSettings _rsmSettings;
        private Stopwatch _stopwatch;

        private int _targetFPS;
        private long _fpsUpdateTime;
        private float _ramUpdateTime;

        private int _passedFrames;
        private long _passedMilliseconds;
        private float _passedSeconds;
        private float _currentFrameTime;
        private float _timeCount = 1f;

        private void Start()
        {
            _rsmSettings = RsmSettings.Instance;
            
            if (_rsmSettings.DontDestroy) DontDestroyOnLoad(this);

            canvas.sortingOrder = _rsmSettings.CanvasSortOrder;

            _targetFPS = _rsmSettings.TargetFrameRate;
            _fpsUpdateTime = _rsmSettings.FpsUpdateTime;
            _ramUpdateTime = _rsmSettings.RamUpdateTime;
            
            QualitySettings.vSyncCount = 0;
            Application.targetFrameRate = _targetFPS;
        
            _stopwatch = Stopwatch.StartNew();
        }

        private void Update()
        {
            if (_timeCount >= _ramUpdateTime)
            {
                _timeCount = 0f;
                allocatedRamText.SetText("Allocated: {0:1}", Profiler.GetTotalAllocatedMemoryLong()/ 1048576f);
                reservedRamText.SetText("Reserved: {0:1}", Profiler.GetTotalReservedMemoryLong() / 1048576f);
                monoRamText.SetText("Mono: {0:1}", Profiler.GetMonoUsedSizeLong() / 1048576f);
            }
            else _timeCount += Time.deltaTime;
            
            if (CurrentFPS >= 50) fpsText.color = Color.green;
            else if (CurrentFPS > 30 && CurrentFPS < 50) fpsText.color = Color.yellow;
            else fpsText.color = Color.red;

            _passedFrames++;

            _passedMilliseconds = _stopwatch.ElapsedMilliseconds;
        
            if (_passedMilliseconds < _fpsUpdateTime) return;

            _passedSeconds = _passedMilliseconds / 1000f;

            CurrentFPS = _passedFrames / _passedSeconds;
            _currentFrameTime = _passedMilliseconds / (_passedFrames * 1f); // `*1f` instead of explicit conversion

            fpsText.SetText("FPS: {0:1} (ms {1:1})", CurrentFPS, _currentFrameTime);

            _passedFrames = 0;
            _stopwatch.Restart();
        }
    }
}
