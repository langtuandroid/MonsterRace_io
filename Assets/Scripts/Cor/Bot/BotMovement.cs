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
        private bool isStopMovement;
        private bool toMonster;

        NavMeshAgent _agent;
        CharacterStatesAnimation _characterStatesAnimation;
        StackBalls _stackBalls;

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
            _agent = GetComponent<NavMeshAgent>();
            _characterStatesAnimation = GetComponentInChildren<CharacterStatesAnimation>();
            _stackBalls = GetComponentInChildren<StackBalls>();
        }

        private void FixedUpdate()
        {
            if (transform.position.x == monsterPoint.position.x || 
                transform.position.z == monsterPoint.position.z){
                toMonster = false;
                return;
            }
        }

        private void Update()
        {
            if (isStopMovement || 
                LevelController.Instance.levelAction != LevelAction.Start)
                return;

            timer += Time.deltaTime;

            if(timer >= timeToMonster)
            {
                int random = Random.Range(3, 8);
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
        }

        public void StopMovement(bool isActive)
        {
            if (isActive)
            {
                isStopMovement = isActive;
                _agent.enabled = false;
                return;
            }

            isStopMovement = false;
            _agent.enabled = true;
        }
    }
}
