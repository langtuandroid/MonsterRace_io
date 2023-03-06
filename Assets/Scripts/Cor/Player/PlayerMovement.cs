using UnityEngine;
using DG.Tweening;

namespace BlueStellar.Cor
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
        Rigidbody _rb;

        private void Start()
        {
            _transformPlayer = GetComponent<Transform>();
            _characterController = GetComponent<CharacterController>();
            _joystick = GameObject.FindObjectOfType<FloatingJoystick>();
            _characterStatesAnimation = GetComponentInChildren<CharacterStatesAnimation>();
            _rb = GetComponent<Rigidbody>();

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
            _characterController.enabled = true;
            _rb.isKinematic = true;
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

        public void JumpToTarget(Transform point)
        {
            transform.DOJump(point.position, 15, 1, 1.8f);
            LockControll(true);
            transform.parent = null;
        }

        public void PushPlayer(Transform dir, float forcePush, bool isBack)
        {
            //Vector3 pushDirection = Vector3.zero;

            //if (!isBack)
              // pushDirection = transform.position + dir.position;
            //if (isBack)
              // pushDirection = transform.position - dir.position;

            _transformPlayer.DOLocalMove(new Vector3(point.position.x, transform.position.y, point.position.z) * forcePush, 0.5f);
            //_transformPlayer.DOJump(new Vector3(0f,0f,0f), 1f, 1, 0.5f);
            //_characterController.enabled = false;
            //_rb.isKinematic = false;
            //_rb.AddForce(point.position * 8f, ForceMode.Impulse);
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

        private void OnTriggerStay(Collider other)
        {
            if (isLockControll)
                return;

            if (other.gameObject.tag == "Respawn")
            {
                if (other.GetComponent<MovingRoad>() == null)
                {
                    transform.parent = other.transform;
                    return;
                }

                if (other.GetComponent<MovingRoad>() != null)
                {
                    if (transform.parent == null)
                        other.GetComponent<MovingRoad>().AddPoint(transform);
                }
            }

            if (other.gameObject.tag == "EditorOnly")
            {
                transform.parent = null;
                speedMovement = 6f;
            }
        }
    }
}
