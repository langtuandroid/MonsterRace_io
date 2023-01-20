using System.Collections.Generic;
using UnityEngine;

namespace PlayKing.Cor
{
    public class ArenaController : MonoBehaviour
    {
        [SerializeField] List<CharacterStates> currencyBots = new List<CharacterStates>();
        [SerializeField] GameObject finishPlatform;

        public void AddBot(CharacterStates characterStates)
        {
            currencyBots.Add(characterStates);
        }

        public void RemoveBot(CharacterStates _characterStates)
        {
            currencyBots.Remove(_characterStates);
            if (currencyBots.Count == 0)
            {
                finishPlatform.SetActive(true);
                LevelController.Instance.LevelCompleted();
            }
        }

        public void RemovePlayer()
        {
            LevelController.Instance.LevelFailed();
        }
    }
}