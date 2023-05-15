using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using DG.Tweening;
using UnityEngine.Serialization;

namespace Core
{
    [RequireComponent(typeof(NavMeshAgent))]
    public class BotMovement : MonoBehaviour
    {
        #region Variables

        [SerializeField] private GameModeType gameModeType;
        [SerializeField] private List<Transform> monsterPoints = new List<Transform>();
        [SerializeField] private CharacterColorType colorType;
        [SerializeField] private List<Vector3> points = new List<Vector3>();
        [SerializeField] private Rigidbody rb;
        [SerializeField] private NavMeshAgent agent;
        [SerializeField] private CharacterAnimation characterAnimation;
        [SerializeField] private StackBalls stackBalls;
        [SerializeField] private float timeToMonster;
        [SerializeField] private float timer;
        [SerializeField] private bool isStopMovement;
        [SerializeField] private bool toMonster;
        [SerializeField] private int min;
        [SerializeField] private int max;
        
        private int _indexMonsterPoint;
        private bool _inMonster;

        private CollectableBallsField _collectableBallsField;
        private Arena _arena;
        private Vector3 _ball;
        public int index;

        #endregion

        private void OnDestroy()
        {
            LevelManager.Instance.OnLevelStart -= Move;
            LevelManager.Instance.OnLevelPause -= Stop;
            LevelManager.Instance.OnLevelContinue -= Move;
            LevelManager.Instance.OnLevelEnd -= Stop;
        }

        private void Start()
        {
            if (gameModeType == GameModeType.Game)
            {
                _collectableBallsField = GameObject.FindObjectOfType<CollectableBallsField>();
            }
            else
            {
                _arena = GameObject.FindObjectOfType<Arena>();
            }
            isStopMovement = true;
            LevelManager.Instance.OnLevelStart += Move;
            LevelManager.Instance.OnLevelPause += Stop;
            LevelManager.Instance.OnLevelContinue += Move;
            LevelManager.Instance.OnLevelEnd += Stop;
        }

        private void Update()
        {
            if (isStopMovement)
                return;

            if (!toMonster && gameModeType == GameModeType.Game)
            {
                if (timer >= timeToMonster)
                {
                    int random = Random.Range(min, max);

                    if (stackBalls.GetCountBalls() >= random)
                    {
                        agent.SetDestination(monsterPoints[_indexMonsterPoint].position);
                        characterAnimation.RunAnimation(true);
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

        public void SetMonsterPoints(Transform pointTarget)
        {
            monsterPoints.Add(pointTarget);
        }

        private void SetPoints()
        {
            if (gameModeType == GameModeType.Game)
            {
                points = _collectableBallsField.GetListTypeBalls(colorType);
                return;
            }

            points = _arena.GetWayPoints();
        }

        private void NewMove()
        {
            if (!agent.enabled)
                return;

            if (Vector3.Distance(transform.position, _ball) < 1)
            {
                NewPoint();
                UpdateMove();
            }
            else
            {
                characterAnimation.RunAnimation(true);
            }
        }

        private void UpdateMove()
        {
            _ball = points[index];

            if(agent.enabled)
                agent.SetDestination(_ball);
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
            agent.enabled = false;
            StopMovement(true);
            characterAnimation.RunAnimation(false);
        }

        public void StopMovement(bool isActive)
        {
            if (isActive)
            {
                isStopMovement = isActive;
                agent.enabled = false;
                return;
            }

            rb.isKinematic = true;
            isStopMovement = false;
            agent.enabled = true;
            toMonster = false;
        }

        public void PushBot(Transform pushTarget)
        {
            agent.enabled = false;
            rb.isKinematic = false;
            Vector3 pushDirection = new Vector3(transform.position.x - pushTarget.position.x,
                transform.position.y, transform.position.z - pushTarget.position.z);
            rb.AddForce(pushDirection * 2f, ForceMode.Impulse);
        }

        public void ThrowBot(Transform point, float force)
        {
            transform.DOLocalMove(new Vector3(point.position.x, transform.position.y, point.position.z), force);
        }

        public void SetNullPoint()
        {
            index = 0;
            UpdateMove();
        }

        public void RestartMovement()
        {
            agent.enabled = true;
            transform.DOKill();
            SetPoints();
            NewPoint();
            UpdateMove();
        }

        public void MonsterReturnMove()
        {
            agent.enabled = true;
            isStopMovement = false;
            NewPoint();
            UpdateMove();
        }

        #region BotCollisions

        private void OnTriggerStay(Collider other)
        {
            if (other.CompareTag("MonsterFields"))
            {
                if (!toMonster || _inMonster) 
                    return;
               
                var ballsMonster = other.GetComponentInParent<CollectableMonster>();
                if (ballsMonster.IsDeactivetedMonster())
                {
                    _indexMonsterPoint++;
                    _inMonster = true;
                }

                points.Clear();
                SetPoints();
                NewPoint();
                UpdateMove();
                toMonster = false;
            }
        }

        private void OnTriggerExit(Collider other)
        {
            _inMonster = false;
        }

        #endregion
    }
}
