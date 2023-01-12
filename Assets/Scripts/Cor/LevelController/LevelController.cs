using UnityEngine;

public enum LevelAction
{
    Start,
    Pause,
    End
}

namespace PlayKing.Cor
{
    public class LevelController : MonoBehaviour
    {
        #region Singelton

        public static LevelController Instance;

        private void Awake()
        {
            Instance = this;
        }

        #endregion

        public LevelAction levelAction;

        public void LevelStart()
        {
            levelAction = LevelAction.Start;
            UIManager.Instance.StartScreen(false);
            UIManager.Instance.LeaderboardScreen(true);
        }

        public void LevelCompleted()
        {
            LevelEnd();
            UIManager.Instance.WinScreen(true);
        }

        public void LevelFailed()
        {
            LevelEnd();
            UIManager.Instance.LoseScreen(true);
        }

        private void LevelEnd()
        {
            levelAction = LevelAction.End;
            UIManager.Instance.LeaderboardScreen(false);
            UIManager.Instance.SettingsScreen(false);
        }
    }
}
