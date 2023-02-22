using UnityEngine;

namespace BlueStellar.Cor
{
    public class AnalyticsController : MonoBehaviour
    {
        public void LevelStart(int lvlNumber)
        {
            TinySauce.OnGameStarted(levelNumber: lvlNumber);
        }

        public void LevelFinished(int lvlNumber)
        {
            TinySauce.OnGameFinished(true, score: 0, levelNumber: lvlNumber);
        }
    }
}
