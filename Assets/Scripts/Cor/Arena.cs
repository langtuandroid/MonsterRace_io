using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace BlueStellar.Cor {
    public class Arena : MonoBehaviour
    {
        #region Variables

        [Header("ArenaBallsPlacement")]
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
