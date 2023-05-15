using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using Core.MyPool;

namespace Core
{
    public class StackBalls : MonoBehaviour
    {
        #region Variables

        [SerializeField] private List<CollectableBall> currencyBalls = new List<CollectableBall>();
        [SerializeField] private List<Transform> currencyStackPoints = new List<Transform>();

        #endregion
        
        public int GetCountBalls()
        {
            return currencyBalls.Count;
        }

        public void AddCollectableBall(CollectableBall ball, bool isAnim)
        {
            foreach (var i in currencyBalls)
            {
                if (ball == i)
                    return;
            }

            currencyBalls.Add(ball);
            var indexBall = currencyBalls.IndexOf(ball);
            ball.transform.position = currencyStackPoints[indexBall].position;
            ball.transform.parent = currencyStackPoints[indexBall];
            ball.BallInStack();
            if (isAnim) { ball.ColorAnimation(); }
        }

       
        public void UnstackCollectablekBalls(CollectableMonster unstackMonster)
        {
            for (int i = currencyBalls.Count - 1; i >= 0; i--)
            {
                currencyBalls[i].transform.SetParent(null);
                currencyBalls[i].transform.DOMove(transform.position + Vector3.up * 4f, 0.25f);
                currencyBalls[i].transform.DOJump(unstackMonster.transform.position, 4, 1, 0.3f).SetDelay(0.25f);
                currencyBalls[i].BallToMonster(unstackMonster);
                currencyBalls.Remove(currencyBalls[i]);
                return;
            }
        }

        public void DestroyedStack()
        {
            foreach (var i in currencyBalls)
            {
                i.BallNeutral();
            }

            currencyBalls.Clear();
        }

        public void ClearStack()
        {
            foreach(var i in currencyBalls)
            {
                Destroy(i.gameObject);
            }

            currencyBalls.Clear();
        }

        public void RemoveCollectableBall()
        {
            if(currencyBalls.Count > 0)
            {
                NightPool.Despawn(currencyBalls[currencyBalls.Count - 1].gameObject, 0.1f);
                currencyBalls.RemoveAt(currencyBalls.Count - 1);
            }
        }
    }
}
