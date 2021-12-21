using UnityEngine;

namespace RightStatsMonitor.Core
{
    public sealed class RsmSettings : ScriptableObject
    {
        #region Instance

        private static RsmSettings _rsmSettings;

        public static RsmSettings Instance => _rsmSettings == null
            ? _rsmSettings = Resources.Load<RsmSettings>("RSM Settings")
            : _rsmSettings;

        #endregion

        [SerializeField] private int targetFrameRate;
        
        [SerializeField, Tooltip("in milliseconds")] private long fpsUpdateTime;
        
        [SerializeField, Tooltip("in seconds")] private float ramUpdateTime;
        
        [SerializeField] private bool initializeAtRuntime;

        [SerializeField] private bool dontDestroy;
        
        [SerializeField] private int canvasSortOrder;
        
        public int TargetFrameRate => targetFrameRate;
        
        public long FpsUpdateTime => fpsUpdateTime;
        
        public float RamUpdateTime => ramUpdateTime;

        public bool InitializeAtRuntime => initializeAtRuntime;
        
        public bool DontDestroy => dontDestroy;

        public int CanvasSortOrder => canvasSortOrder;
    }
}