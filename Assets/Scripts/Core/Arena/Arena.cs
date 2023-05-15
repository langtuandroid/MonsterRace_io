using System.Collections.Generic;
using UnityEngine;
using Core.MyPool;

namespace Core
{
    public class Arena : MonoBehaviour
    {
        #region Variables

        [Header("ArenaBallsPlacement")]
        [SerializeField] private List<BallType> ballTypes;
        [SerializeField] private Transform[] placementBallsPoints;
        [SerializeField] private PoolPreset poolPreset;
        [SerializeField] private int maxTypes;
        [SerializeField] private int countBalls;

        [Space]
        [Header("ArenaPlayer")]
        [SerializeField] private Transform playerPoint;

        [Space]
        [Header("ArenaBots")]
        [SerializeField] private Transform[] botsPoints;
        [SerializeField] private Transform[] monsterPoints;

        [Space]
        [Header("ArenaMonsters")]
        [SerializeField] private CollectableMonster[] collectableMonsters;

        [Space]
        [Header("ArenaGates")]
        [SerializeField] private List<GatesType> gatesTypes;
        [SerializeField] private List<Transform> points;

        [Space]
        [Header("Points")]
        [SerializeField] private List<Transform> pointsPlacement;

        #endregion

        public int GetCountBalls()
        {
            return countBalls;
        }

        public List<BallType> GetBallTypes()
        {
            return ballTypes;
        }

        public PoolPreset GetPreset()
        {
            return poolPreset;
        }

        public Transform[] GetBallsPoints()
        {
            return placementBallsPoints;
        }

        public Transform GetPlayerPoint()
        {
            return playerPoint;
        }

        public Transform[] GetPoints()
        {
            return botsPoints;
        }

        public Transform[] GetMonsterPoints()
        {
            return monsterPoints;
        }

        public List<GatesType> GetGateTypes()
        {
            return gatesTypes;
        }

        public List<Transform> GetGatesPoints()
        {
            return points;
        }

        public List<Vector3> GetWayPoints()
        {
            List<Vector3> wayPoints = new List<Vector3>();
            foreach (var i in pointsPlacement) wayPoints.Add(i.position);
            return wayPoints;
        }

        public CollectableMonster[] GetCollectableMonsters()
        {
            return collectableMonsters;
        }
    }
}
