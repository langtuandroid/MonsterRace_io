using System.Collections.Generic;
using UnityEngine;

namespace Cor
{
    public class ArenaManager : MonoBehaviour
    {
        #region Variables

        [SerializeField] List<CharacterStates> currencyBots = new List<CharacterStates>();

        #endregion

        public void AddBot(CharacterStates characterStates)
        {
            currencyBots.Add(characterStates);
        }

        public void RemoveBot(CharacterStates _characterStates)
        {
            currencyBots.Remove(_characterStates);
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