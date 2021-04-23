using UnityEditor;
using UnityEngine;

namespace RightStatsMonitor.Editor
{
    public class InstantiateStatsMonitor : MonoBehaviour
    {
        [MenuItem("Tools/RightStatsMonitor/Add to scene")]
        private static void InstStatsMonitorInTheScene()
        {
            if (GameObject.Find("RSM")) EditorUtility.DisplayDialog("RightStatsMonitor is already in the scene",
                "", "OK");
            else Instantiate(Resources.Load("RightStatsMonitor")).name = "RSM";
        }
    }
}
