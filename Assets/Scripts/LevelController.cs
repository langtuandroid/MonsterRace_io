using System.Collections;
using System.Collections.Generic;
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
        }

        public void LevelCompleted()
        {

        }

        public void LevelFailed()
        {

        }

        private void LevelEnd()
        {
            levelAction = LevelAction.End;
        }
    }
}
