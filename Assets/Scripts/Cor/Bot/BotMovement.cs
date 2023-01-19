using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

namespace PlayKing.Cor
{
    [RequireComponent(typeof(NavMeshAgent))]
    public class BotMovement : MonoBehaviour
    {
        [SerializeField] Transform centerPoint;
        [SerializeField] Transform[] monsterPoints;
        [SerializeField] private float range;
        [SerializeField] private float timeToMonster;
        [SerializeField] private float timer;
        [SerializeField] private bool isStopMovement;
        [SerializeField] private bool toMonster;
        [SerializeField] CharacterColorType colorType;
        [SerializeField] List<Vector3> points = new List<Vector3>();
        [SerializeField] int min;
        [SerializeField] int max;
        private int indexMonsterPoint;

        Rigidbody _rb;
        NavMeshAgent _agent;
        CharacterStatesAnimation _characterStatesAnimation;
        CollectableBallsField _collectableBallsField;
        StackBalls _stackBalls;
        public Vector3 ball;
        public int index;

        private void Start()
        {
            _rb = GetComponent<Rigidbody>();
            _agent = GetComponent<NavMeshAgent>();
            _characterStatesAnimation = GetComponentInChildren<CharacterStatesAnimation>();
            _stackBalls = GetComponentInChildren<StackBalls>();
            _collectableBallsField = GameObject.FindObjectOfType<CollectableBallsField>();
            isStopMovement = true;
            LevelController.Instance.OnLevelStart.AddListener(Move);
            LevelController.Instance.OnLevelEnd.AddListener(Stop);
        }

        private void Update()
        {
            if (isStopMovement)
                return;

            if (!toMonster)
            {
                if (timer >= timeToMonster)
                {
                    int random = Random.Range(min, max);
                    if (_stackBalls.AmmountBalls() >= random)
                    {
                        _agent.SetDestination(monsterPoints[indexMonsterPoint].position);
                        _characterStatesAnimation.RunAnimation(true);
                        timer = 0f;
                        toMonster = true;
                        return;
                    }

                    timer = 0f;
                }
            }

            if (toMonster)
                return;

            timer += Time.deltaTime;

            NewMove();
        }

         #region PlatformMovement

        private void SetPoints()
        {
            points = _collectableBallsField.ListTypeBalls(colorType);
        }

        private void NewMove()
        {
            if (Vector3.Distance(transform.position, ball) < 1)
            {
                NewPoint();
                UpdateMove();

                _characterStatesAnimation.RunAnimation(false);
            }
            else
            {
                _characterStatesAnimation.RunAnimation(true);
            }
        }

        private void UpdateMove()
        {
            ball = points[index];
            _agent.SetDestination(ball);
            _characterStatesAnimation.RunAnimation(true);
        }

        private void NewPoint()
        {
            index = Random.Range(0, points.Count - 1);
        }

        #endregion

        public void Move()
        {
            SetPoints();
            index = Random.Range(0, points.Count - 1);
            UpdateMove();
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
                transform.position.y, transform.position.z - dir.position.z);
            _rb.AddForce(pushDirection * 2f, ForceMode.Impulse);
        }

        public void RestartMovement()
        {
            NewPoint();
            UpdateMove();
        }

        private bool inMonster;

        private void OnTriggerStay(Collider other)
        {
            if (other.CompareTag("MonsterFields"))
            {
                if (toMonster)
                {
                    if (inMonster)
                        return;

                    BallsMonster ballsMonster = other.GetComponentInParent<BallsMonster>();
                    if(ballsMonster.IsDeactivetedMonster())
                    {
                        indexMonsterPoint++;
                        inMonster = true;
                    }

                    points.Clear();
                    SetPoints();
                    NewPoint();
                    UpdateMove();
                    toMonster = false;
                }
            }
        }

        private void OnTriggerExit(Collider other)
        {
            inMonster = false;
        }
    }
}
