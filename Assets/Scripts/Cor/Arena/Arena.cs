using System.Collections.Generic;
using UnityEngine;

namespace PlayKing.Cor
{
    public class Arena : MonoBehaviour
    {
        [SerializeField] List<CharacterStates> currencyBots = new List<CharacterStates>();

        private void Update()
        {
            if (Input.GetKeyDown("a"))
            {
                LevelController.Instance.LevelCompleted();
            }
        }

        public void AddBot(CharacterStates characterStates)
        {
            currencyBots.Add(characterStates);
        }

        public void RemoveBot(CharacterStates _characterStates)
        {
            currencyBots.Remove(_characterStates);
            if (currencyBots.Count == 0)
                LevelController.Instance.LevelCompleted();
        }

        public void RemovePlayer()
        {
            LevelController.Instance.LevelFailed();
        }
    }
}