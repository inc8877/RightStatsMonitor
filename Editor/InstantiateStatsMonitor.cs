#if UNITY_EDITOR
using RightStatsMonitor.Core;
using UnityEditor;
using UnityEngine;

namespace RightStatsMonitor.Editor
{
    internal sealed class InstantiateStatsMonitor : MonoBehaviour
    {
        [MenuItem("Tools/RightStatsMonitor/Settings")]
        private static void OpenRsmSettings()
        {
            Selection.activeObject = RsmSettings.Instance;
        }
        
        [MenuItem("Tools/RightStatsMonitor/Add to scene")]
        private static void InstStatsMonitorInTheScene()
        {
            if (FindObjectOfType<RSMCore>()) EditorUtility.DisplayDialog("RightStatsMonitor is already in the scene",
                "", "OK");
            else Instantiate(Resources.Load("RightStatsMonitor")).name = "RSM";
        }
    }
}
#endif