using System.Collections.Generic;
using UnityEngine;

namespace Cor
{
    public class ArenaManager : MonoBehaviour
    {
        #region Singelton

        public static ArenaManager Instance;

        private void Awake()
        {
            Instance = this;
        }

        #endregion

        #region Variables

        [SerializeField] List<Character> currencyBots = new List<Character>();

        #endregion

        public void AddBot(Character _character)
        {
            currencyBots.Add(_character);
        }

        public void RemoveBot(Character _character)
        {
            currencyBots.Remove(_character);
            if (currencyBots.Count == 0)
            {
                LevelManager.Instance.LevelCompleted();
            }
        }

        public void RemovePlayer()
        {
            LevelManager.Instance.LevelFailed();
        }
    }
}