using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace BlueStellar.Cor {
    public class Arena : MonoBehaviour
    {
        #region Variables

        [Header("ArenaBallsPlacement")]
        [SerializeField] Transform[] placementBallsPoints;
        [SerializeField] private int ammountBalls;
        [SerializeField] Transform playerPoint;
        [SerializeField] Transform[] botsPoints;
        [SerializeField] Transform[] monsterPoints;

        #endregion

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
    }
}
