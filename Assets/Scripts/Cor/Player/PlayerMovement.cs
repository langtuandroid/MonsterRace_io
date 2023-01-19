using UnityEngine;
using DG.Tweening;

namespace PlayKing.Cor
{
    [RequireComponent(typeof(CharacterController))]
    public class PlayerMovement : MonoBehaviour
    {
        [Header("MovementSettings")]
        [SerializeField] Transform groundCheck;
        [SerializeField] LayerMask groundMask;
        [SerializeField] private float gravityMultyplier;
        [SerializeField] private float groundDistance;
        [SerializeField] private float speedMovement;
        [SerializeField] private float speedRotate;
        [SerializeField] private bool isLockControll;
        [SerializeField] Transform point;
        Vector3 gravityVelocity;
        Transform _transformPlayer;
        CharacterController _characterController;
        FloatingJoystick _joystick;
        CharacterStatesAnimation _characterStatesAnimation;

        private void Start()
        {
            _transformPlayer = GetComponent<Transform>();
            _characterController = GetComponent<CharacterController>();
            _joystick = GameObject.FindObjectOfType<FloatingJoystick>();
            _characterStatesAnimation = GetComponentInChildren<CharacterStatesAnimation>();
            LockControll(true);
            LevelController.Instance.OnLevelStart.AddListener(Move);
            LevelController.Instance.OnLevelEnd.AddListener(Stop);
        }

        private void Update()
        {
            if (isLockControll)
                return;

            MovementControll();
        }

        public void LockControll(bool lockControll)
        {
            isLockControll = lockControll;
        }

        public void Move()
        {
            LockControll(false);
        }

        public void Stop()
        {
            LockControll(true);
        }

        public void MovementToTarget(Transform target)
        {
            _transformPlayer.DOMove(new Vector3(target.position.x, 
                _transformPlayer.position.y, target.position.z), 0.4f);
        }

        public void JumpToTarget()
        {
            transform.DOJump(point.position, 15, 1, 1.8f);
            LockControll(true);
        }

        public void PushPlayer(Transform dir)
        {
            Vector3 pushDirection = new Vector3(transform.position.x - dir.position.x,
                transform.position.y, transform.position.z - dir.position.z);
            _transformPlayer.DOJump(pushDirection, 1f, 1, 0.5f);
        }

        private void MovementControll()
        {
            if (Input.GetMouseButton(0))
            {
                if (_joystick != null)
                {
                    var xInput = _joystick.Horizontal;
                    var yInput = _joystick.Vertical;

                    _characterController.Move((Vector3.right * xInput + Vector3.forward * yInput) * speedMovement * Time.deltaTime);

                    _transformPlayer.LookAt(transform.position + (Vector3.right * xInput + Vector3.forward * yInput) * speedRotate * Time.deltaTime);

                    var isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);

                    if (isGrounded && gravityVelocity.y < 0 && isGrounded && gravityVelocity.y > 1)
                    {
                        gravityVelocity.y = -2f;
                    }

                    gravityVelocity += Vector3.up * gravityMultyplier * Time.deltaTime;
                    _characterController.Move(gravityVelocity);

                    if (xInput >= 0.1f || xInput <= -0.1f ||
                        yInput >= 0.1f || yInput <= -0.1f){
                        _characterStatesAnimation.RunAnimation(true);
                    }
                    else { _characterStatesAnimation.RunAnimation(false); }
                }
            }

            if (Input.GetMouseButtonUp(0))
            {
                _characterStatesAnimation.RunAnimation(false);
            }
        }
    }
}
