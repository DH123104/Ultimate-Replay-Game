using UltimateReplay.Statistics;
using UnityEngine;

namespace UltimateReplay
{
    /// </summary>
    public class ReplayStatistics : MonoBehaviour
    {
        // Methods
        public void OnGUI()
        {
            // Get memory usage
            int memoryUsage = ReplayStorageTargetStatistics.CalculateReplayMemoryUsage();

            GUILayout.Space(32);
            GUILayout.Label("Replay Memory Usage: " + ReplayStatisticsUtil.GetMemorySizeSmallestUnit(memoryUsage) + ReplayStatisticsUtil.GetMemoryUnitString(memoryUsage));
        }
    }
}
