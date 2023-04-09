using System.Collections.Generic;
using UnityEngine;

namespace Cor
{
    public class Arena : MonoBehaviour
    {
        #region Variables

        [Header("ArenaBallsPlacement")]
        [SerializeField] List<BallType> ballTypes = new List<BallType>();
        [SerializeField] Transform[] placementBallsPoints;
        [SerializeField] private int maxTypes;
        [SerializeField] private int ammountBalls;

        [Header("ArenaPlayer")]
        [SerializeField] Transform playerPoint;

        [Header("ArenaBots")]
        [SerializeField] Transform[] botsPoints;
        [SerializeField] Transform[] monsterPoints;

        [Header("ArenaMonsters")]
        [SerializeField] CollectableMonster[] collectableMonsters;

        [Header("ArenaGates")]
        [SerializeField] List<GatesType> gatesTypes = new List<GatesType>();
        [SerializeField] List<Transform> points = new List<Transform>();

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

        public CollectableMonster[] GetCollectableMonsters()
        {
            return collectableMonsters;
        }
    }
}
