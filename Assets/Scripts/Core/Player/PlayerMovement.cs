using UnityEngine;
using DG.Tweening;
using UnityEngine.Serialization;

namespace Core
{
    [RequireComponent(typeof(CharacterController))]
    public class PlayerMovement : MonoBehaviour
    {
        #region Variables

        [Header("MovementSettings")]
        [SerializeField] private Transform groundCheck;
        [SerializeField] private LayerMask groundMask;
        [SerializeField] private float gravityMultyplier;
        [SerializeField] private float groundDistance;
        [SerializeField] private float speedMovement;
        [SerializeField] private float speedRotate;
        [SerializeField] private bool isLockControll;
        
        [Space]
        [Header("Animations")]
        [SerializeField] private CharacterAnimation characterAnimation;

        private float _xInput;
        private float _yInput;

        private Vector3 gravityVelocity;
        private Transform _transformPlayer;
        private CharacterController _characterController;

        #endregion

        private void OnEnable()
        {
            LevelManager.Instance.OnLevelEnd += StopedMovement;
        }

        private void OnDisable()
        {
            LevelManager.Instance.OnLevelEnd -= StopedMovement;
        }

        private void Start()
        {
            _transformPlayer = GetComponent<Transform>();
            _characterController = GetComponent<CharacterController>();
        }

        private void Update()
        {
            if (isLockControll)
                return;

            Movement();
        }

        public void LockControll(bool lockControll)
        {
            isLockControll = lockControll;
            if (!lockControll) { _transformPlayer.DOKill(); }
        }

        public void Move() => LockControll(false);

        public void StopedMovement() => LockControll(true);

        public void MovementToTarget(Transform target)
        {
            _transformPlayer.DOMove(new Vector3(target.position.x, 
                _transformPlayer.position.y, target.position.z), 0.4f);
        }

        public void JumpToTarget(Transform point)
        {
            transform.DOJump(point.position, 15, 1, 1.8f);
            LockControll(true);
            transform.parent = null;
        }

        public void PushPlayer(Transform dir, float force)
        {
            _transformPlayer.DOLocalMove(new Vector3(dir.position.x, transform.position.y, dir.position.z), force);
        }

        private void Movement()
        {
            _characterController.Move((Vector3.right * _xInput + Vector3.forward * _yInput) * speedMovement * Time.deltaTime);

            _transformPlayer.LookAt(transform.position + (Vector3.right * _xInput + Vector3.forward * _yInput) * speedRotate * Time.deltaTime);

            var isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);

            if (isGrounded && gravityVelocity.y < 0 && isGrounded && gravityVelocity.y > 1)
            {
                gravityVelocity.y = -2f;
            }

            gravityVelocity += Vector3.up * gravityMultyplier * Time.deltaTime;
            _characterController.Move(gravityVelocity);
        }

        public void MovementControll(float horizontal, float vertical, bool isMove)
        { 
            if (isMove)
            {
                _xInput = horizontal;
                _yInput = vertical;
                if (_xInput >= 0.1f || _xInput <= -0.1f ||
                      _yInput >= 0.1f || _yInput <= -0.1f)
                {
                    characterAnimation.RunAnimation(true);
                }
                else { characterAnimation.RunAnimation(false); }
                return;
            }

            _xInput = 0;
            _yInput = 0;
            characterAnimation.RunAnimation(false);
        }

        private void OnTriggerStay(Collider other)
        {
            if (isLockControll)
                return;

            if (other.CompareTag("Respawn"))
            {
                if (other.GetComponent<MovingRoad>() == null)
                {
                    transform.parent = other.transform;
                    speedMovement = 9f;
                    return;
                }

                if (other.GetComponent<MovingRoad>() != null)
                {
                    if (transform.parent == null)
                        other.GetComponent<MovingRoad>().AddPoint(transform);
                }
            }

            if (other.CompareTag("EditorOnly"))
            {
                transform.parent = null;
                speedMovement = 6f;
            }
        }
    }
}
