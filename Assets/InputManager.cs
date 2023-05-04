using UnityEngine;

namespace Cor
{
    public class InputManager : MonoBehaviour
    {
        #region Variables

        private bool isFightMode;

        private PlayerMovement _playerMovement;
        private CharacterFight _characterFight;

        #endregion

        private void Start()
        {
            SetPlayer(GameObject.FindObjectOfType<PlayerMovement>());
            LevelManager.Instance.OnLevelFight += Fight;
        }

        public void SetPlayer(PlayerMovement player)
        {
            _playerMovement = player;
            _characterFight = player.GetComponent<CharacterFight>();
        }

        private void Update()
        {
            if (Input.GetMouseButtonDown(0))
            {
    
            }

            if (Input.GetMouseButton(0))
            {
                _playerMovement.MovementControll(true);
            }

            if (Input.GetMouseButtonUp(0))
            {
                _playerMovement.MovementControll(false);
                if (!isFightMode)
                    return;
                _characterFight.Attack();
            }
        }

        private void Fight() => isFightMode = true;
    }
}
