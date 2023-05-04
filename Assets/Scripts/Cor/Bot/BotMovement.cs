using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using DG.Tweening;

namespace Cor
{
    [RequireComponent(typeof(NavMeshAgent))]
    public class BotMovement : MonoBehaviour
    {
        #region Variables

        [SerializeField] List<Transform> monsterPoints = new List<Transform>();
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
        private bool inMonster;

        [SerializeField] Rigidbody _rb;
        [SerializeField] NavMeshAgent _agent;
        [SerializeField] CharacterStatesAnimation _characterStatesAnimation;
        [SerializeField] StackBalls _stackBalls;
        CollectableBallsField _collectableBallsField;
        Vector3 ball;
        public int index;

        #endregion

        private void Start()
        {
            _collectableBallsField = GameObject.FindObjectOfType<CollectableBallsField>();
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

        public void SetMonsterPoints(Transform pointTarget)
        {
            monsterPoints.Add(pointTarget);
            //monsterPoints.Add(nextTarget);
        }

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
            }
            else
            {
                _characterStatesAnimation.RunAnimation(true);
            }
        }

        private void UpdateMove()
        {
            ball = points[index];

            if(_agent.enabled)
                _agent.SetDestination(ball);
            //_characterStatesAnimation.RunAnimation(true);
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
            _characterStatesAnimation.RunAnimation(false);
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
            toMonster = false;
        }

        public void PushBot(Transform pushTarget)
        {
            _agent.enabled = false;
            _rb.isKinematic = false;
            Vector3 pushDirection = new Vector3(transform.position.x - pushTarget.position.x,
                transform.position.y, transform.position.z - pushTarget.position.z);
            _rb.AddForce(pushDirection * 2f, ForceMode.Impulse);
        }

        public void ThrowBot(Transform point, float force)
        {
            transform.DOLocalMove(new Vector3(point.position.x, transform.position.y, point.position.z), force);
        }

        public void RestartMovement()
        {
            _agent.enabled = true;
            transform.DOKill();
            SetPoints();
            NewPoint();
            UpdateMove();
        }

        public void MonsterReturnMove()
        {
            _agent.enabled = true;
            isStopMovement = false;
            NewPoint();
            UpdateMove();
        }

        #region BotCollisions

        private void OnTriggerStay(Collider other)
        {
            if (other.gameObject.tag == "MonsterFields")
            {
                if (toMonster)
                {
                    if (inMonster)
                        return;

                    CollectableMonster ballsMonster = other.GetComponentInParent<CollectableMonster>();
                    if (ballsMonster.IsDeactivetedMonster())
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

        #endregion
    }
}
