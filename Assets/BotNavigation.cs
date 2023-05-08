using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

namespace Cor
{
    public class BotNavigation : MonoBehaviour
    {
        #region Variables

        [SerializeField] NavMeshAgent _agent;
        [SerializeField] List<Transform> points = new List<Transform>();
        [SerializeField] Vector3 point;
        [SerializeField] CharacterAnimation _characterAnimation;
        private int index;
        private Arena arena;

        #endregion

        private void Start()
        {
            arena = GameObject.FindObjectOfType<Arena>();
            LevelManager.Instance.OnLevelStart += StartMovement;
        }

        private void Update()
        {
            NewMove();
        }

        private void SetPoints()
        {
            points = arena.GetPointsPlacement();
        }

        private void NewMove()
        {
            if (Vector3.Distance(transform.position, point) < 1)
            {
                NewPoint();
                UpdateMove();
            }
            else
            {
                _characterAnimation.RunAnimation(true);
            }
        }

        private void UpdateMove()
        {
            point = points[index].position;

            if (_agent.enabled)
                _agent.SetDestination(point);
        }

        private void NewPoint()
        {
            index = Random.Range(0, points.Count - 1);
        }

        private void StartMovement()
        {
            SetPoints();
            UpdateMove();
        }
    }
}