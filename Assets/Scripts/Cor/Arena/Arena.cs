using System.Collections.Generic;
using UnityEngine;
using Cor.MyPool;

namespace Cor
{
    public class Arena : MonoBehaviour
    {
        #region Variables

        [Header("ArenaBallsPlacement")]
        [SerializeField] List<BallType> ballTypes = new List<BallType>();
        [SerializeField] Transform[] placementBallsPoints;
        [SerializeField] PoolPreset poolPreset;
        [SerializeField] private int maxTypes;
        [SerializeField] private int ammountBalls;

        [Space]
        [Header("ArenaPlayer")]
        [SerializeField] Transform playerPoint;

        [Space]
        [Header("ArenaBots")]
        [SerializeField] Transform[] botsPoints;
        [SerializeField] Transform[] monsterPoints;

        [Space]
        [Header("ArenaMonsters")]
        [SerializeField] CollectableMonster[] collectableMonsters;

        [Space]
        [Header("ArenaGates")]
        [SerializeField] List<GatesType> gatesTypes = new List<GatesType>();
        [SerializeField] List<Transform> points = new List<Transform>();

        [Space]
        [Header("Points")]
        [SerializeField] List<Transform> pointsPlacement = new List<Transform>();

        #endregion

        public int GetMaxTypes()
        {
            return maxTypes;
        }

        public int GetAmmountBalls()
        {
            return ammountBalls;
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

        public List<Transform> GetPointsPlacement()
        {
            return pointsPlacement;
        }

        public CollectableMonster[] GetCollectableMonsters()
        {
            return collectableMonsters;
        }
    }
}
