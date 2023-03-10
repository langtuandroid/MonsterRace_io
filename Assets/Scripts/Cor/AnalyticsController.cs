using UnityEngine;

namespace BlueStellar.Cor
{
    public class AnalyticsController : MonoBehaviour
    {
        public void LevelStart(int lvlNumber)
        {
            TinySauce.OnGameStarted(levelNumber: lvlNumber);
        }

        public void LevelFinished(bool result, int lvlNumber)
        {
            TinySauce.OnGameFinished(result, score: 0, levelNumber: lvlNumber);
        }
    }
}
