using UnityEngine;

namespace Cor
{
    public class InputManager : MonoBehaviour
    {
        #region Variables

        [SerializeField] FloatingJoystick _joystick;
        [SerializeField] private bool isFightMode;

        private bool isLockControll;
        private PlayerMovement _playerMovement;
        private CharacterFight _characterFight;

        #endregion

        private void Start()
        {
            SetPlayer(GameObject.FindObjectOfType<PlayerMovement>());
            LevelManager.Instance.OnLevelFight += Fight;
            LevelManager.Instance.OnLevelEnd += LockedControll;
        }

        public void SetPlayer(PlayerMovement player)
        {
            _playerMovement = player;
            _characterFight = player.GetComponent<CharacterFight>();
        }

        private void Update()
        {
            if (isLockControll)
                return;

            if (Input.GetMouseButton(0))
            {
                _playerMovement.MovementControll(_joystick.Horizontal, _joystick.Vertical, true);
            }

            if (Input.GetMouseButtonUp(0))
            {
                _playerMovement.MovementControll(0, 0, false);
                if (!isFightMode)
                    return;
                _characterFight.Attack();
            }
        }

        private void Fight() => isFightMode = true;

        private void LockedControll() => isLockControll = true;
    }
}
