using System.Collections.Generic;
using UnityEngine;

namespace Core
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

        [SerializeField] private List<Character> currencyBots;

        #endregion

        public void AddBot(Character character)
        {
            currencyBots.Add(character);
        }

        public void RemoveBot(Character character)
        {
            currencyBots.Remove(character);
            if (currencyBots.Count > 0)
                return;
            
            LevelManager.Instance.LevelCompleted();
        }

        public void RemovePlayer()
        {
            LevelManager.Instance.LevelFailed();
        }
    }
}