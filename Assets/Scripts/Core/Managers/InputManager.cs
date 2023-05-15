using UnityEngine;

namespace Core
{
    public class InputManager : MonoBehaviour
    {
        #region Variables

        [SerializeField] private FloatingJoystick _joystick;
        [SerializeField] private bool isFightMode;

        private bool _isLockControll;
        private bool _clicked;
        private PlayerMovement _playerMovement;
        private CharacterFight _characterFight;

        #endregion

        private void Start()
        {
            SetPlayer(GameObject.FindObjectOfType<PlayerMovement>());
            LevelManager.Instance.OnLevelFight += Fight;
            LevelManager.Instance.OnLevelEnd += LockedControl;
        }

        public void SetPlayer(PlayerMovement player)
        {
            _playerMovement = player;
            _characterFight = player.GetComponent<CharacterFight>();
        }

        private void Update()
        {
            if (_isLockControll)
                return;

            if (Input.GetMouseButtonDown(0))
            {
                if (_joystick.IsTouch)
                {
                    _clicked = true;
                }
            }

            if (Input.GetMouseButton(0))
            {
                _playerMovement.MovementControll(_joystick.Horizontal, _joystick.Vertical, true);
            }

            if (Input.GetMouseButtonUp(0))
            {
                _playerMovement.MovementControll(0, 0, false);
                if (!isFightMode)
                    return;
                if (_clicked)
                {
                    _characterFight.Attack();
                    _clicked = false;
                }
            }
        }

        private void Fight() => isFightMode = true;

        private void LockedControl() => _isLockControll = true;
    }
}
