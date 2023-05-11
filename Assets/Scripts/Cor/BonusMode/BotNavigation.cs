using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

namespace Cor
{
    [RequireComponent(typeof(NavMeshAgent))]
    public class BotNavigation : MonoBehaviour
    {
        #region Variables

        [Header("Agent")]
        [SerializeField] NavMeshAgent _agent;

        [Space]
        [Header("WayPoints")]
        [SerializeField] List<Transform> wayPoints = new List<Transform>();
        [SerializeField] Vector3 point;

        [Space]
        [Header("Animations")]
        [SerializeField] CharacterAnimation _characterAnimation;

        private int index;
        private bool canMovement;

        #endregion

        private void OnEnable()
        {
            LevelManager.Instance.OnLevelStart += StartMovement;
            LevelManager.Instance.OnLevelEnd += StopMovement;
        }

        private void OnDestroy()
        {
            LevelManager.Instance.OnLevelStart -= StartMovement;
            LevelManager.Instance.OnLevelEnd -= StopMovement;
        }

        private void Update()
        {
            Movement();
        }

        #region SetVariablesNavigation

        public void SetMovementStatus(bool isMovement)
        {
            if (isMovement)
            {
                StartMovement();
                return;
            }

            StopMovement();
        }

        public void SetWayPoints(List<Transform> points)
        {
            wayPoints.Clear();
            wayPoints = points;
        }

        public void SetTargetPoint(Vector3 target) => point = target;

        #endregion

        #region Movement

        private void Movement()
        {
            if (!canMovement)
                return;

            if (Vector3.Distance(transform.position, point) < 1)
            {
                NewPoint();
                UpdateMove();
                return;
            }

            _characterAnimation.RunAnimation(true);
        }

        private void UpdateMove()
        {
            point = wayPoints[index].position;

            if (_agent.enabled)
                _agent.SetDestination(point);
        }

        private void NewPoint()
        {
            index = Random.Range(0, wayPoints.Count - 1);
        }

        private void StartMovement()
        {
            canMovement = true;
            UpdateMove();
        }

        private void StopMovement()
        {
            canMovement = false;
        }

        #endregion
    }
}