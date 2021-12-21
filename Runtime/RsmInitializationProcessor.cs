using UnityEngine;

namespace RightStatsMonitor.Core
{
    internal static class RsmInitializationProcessor
    {
        [RuntimeInitializeOnLoadMethod]
        private static void InitializationProcessor()
        {
            var settings = RsmSettings.Instance;

            if (settings.InitializeAtRuntime)
            {
                if (GameObject.FindObjectsOfType<RSMCore>().Length > 1)
                {
                    Debug.Log("RSM is already added to scene");
                    return;
                }
                GameObject.Instantiate(Resources.Load("RightStatsMonitor")).name = "RSM";
            }
        }
    }
}