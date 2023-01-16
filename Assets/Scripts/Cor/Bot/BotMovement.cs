using UnityEngine;
using UnityEngine.AI;

namespace PlayKing.Cor
{
    [RequireComponent(typeof(NavMeshAgent))]
    public class BotMovement : MonoBehaviour
    {
        [SerializeField] Transform centerPoint;
        [SerializeField] Transform monsterPoint;
        [SerializeField] private float range;
        [SerializeField] private float timeToMonster;
        [SerializeField] private float timer;
        [SerializeField] private bool isStopMovement;
        [SerializeField] private bool toMonster;
        [SerializeField] CharacterColorType colorType;
        public Collider[] isfind;
        public float sightRange;
        public LayerMask whatIs;
        public bool isd;
        public Transform t;

        Rigidbody _rb;
        NavMeshAgent _agent;
        CharacterStates _characterStates;
        CharacterStatesAnimation _characterStatesAnimation;
        StackBalls _stackBalls;
        public CollectableBall collectableBall;

        private bool RandomPoint(Vector3 center, float range, out Vector3 result)
        {
            Vector3 randomPoint = center + Random.insideUnitSphere * range;
            NavMeshHit hit;

            if (NavMesh.SamplePosition(randomPoint, out hit, 1.0f, NavMesh.AllAreas))
            {
                result = hit.position;
                return true;
            }

            result = Vector3.zero;
            return false;
        }

        private void Start()
        {
            _rb = GetComponent<Rigidbody>();
            _agent = GetComponent<NavMeshAgent>();
            _characterStates = GetComponentInChildren<CharacterStates>();
            _characterStatesAnimation = GetComponentInChildren<CharacterStatesAnimation>();
            _stackBalls = GetComponentInChildren<StackBalls>();
            isStopMovement = true;
            LevelController.Instance.OnLevelStart.AddListener(Move);
            LevelController.Instance.OnLevelEnd.AddListener(Stop);
        }

        private void Update()
        {
            Movement();
        }

        public void Move()
        {
            StopMovement(false);
        }

        public void Stop()
        {
            StopMovement(true);
        }

        public void StopMovement(bool isActive)
        {
            if (isActive)
            {
                isStopMovement = isActive;
                _agent.enabled = false;
                return;
            }

            _rb.isKinematic = true;
            isStopMovement = false;
            _agent.enabled = true;
        }

        public void PushBot(Transform dir)
        {
            _rb.isKinematic = false;
            Vector3 pushDirection = new Vector3(transform.position.x - dir.position.x, 
                transform.position.y, transform.position.x - dir.position.x);
            _rb.AddForce(pushDirection * 3f, ForceMode.Impulse);
        }

        private void Movement()
        {
            if (isStopMovement)
                return;

            if(_characterStates.IsMonsterStage())
            {
                if (_agent.remainingDistance <= _agent.stoppingDistance)
                {
                    Vector3 point;
                    if (RandomPoint(centerPoint.position, range, out point))
                    {
                        Debug.DrawRay(point, Vector3.up, Color.blue, 1.0f);
                        _agent.SetDestination(point);
                        _characterStatesAnimation.RunAnimation(true);
                    }
                }
                return;
            }    

            timer += Time.deltaTime;

            if (timer >= timeToMonster)
            {
                int random = Random.Range(10, 15);
                if (_stackBalls.AmmountBalls() <= random)
                {
                    timer = 0f;
                    return;
                }

                toMonster = true;
                timer = 0f;
            }

            if (toMonster)
            {
                _agent.SetDestination(monsterPoint.position);
                _characterStatesAnimation.RunAnimation(true);
                return;
            }

            if (!toMonster)
            {
                if (isd)
                {
                    if (_agent.remainingDistance <= _agent.stoppingDistance && collectableBall.IsTrueCharacter(colorType))
                    {
                        _agent.SetDestination(collectableBall.transform.position);
                        _characterStatesAnimation.RunAnimation(true);
                    }
                    else
                    {
                        collectableBall = null;
                        isd = false;
                        Find();
                    }
                }
            }
            Find();
        }

        private void Find()
        {
            if (isd)
                return;

            isfind = Physics.OverlapSphere(centerPoint.position, sightRange, whatIs);
            foreach (var i in isfind)
            {
                if (i.gameObject.GetComponent<CollectableBall>() != null)
                {
                    if (i.gameObject.GetComponent<CollectableBall>().IsTrueCharacter(colorType))
                    {
                        collectableBall = i.gameObject.GetComponent<CollectableBall>();
                        isd = true;
                    }
                }
            }
        }

        private void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("MonsterFields"))
            {
                toMonster = false;
            }
        }

        private void OnDrawGizmosSelected()
        {
            Gizmos.color = Color.yellow;
            Gizmos.DrawWireSphere(transform.position, sightRange);
        }
    }
}
