using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

namespace PlayKing.Cor
{
    public class StackBalls : MonoBehaviour
    {
        [SerializeField] List<CollectableBall> currencyBalls = new List<CollectableBall>();
        [SerializeField] List<Transform> currencyStackPoints = new List<Transform>(); //rework this solution

        public void AddCollectableBall(CollectableBall _ball)
        {
            currencyBalls.Add(_ball);
            int indexBall = currencyBalls.IndexOf(_ball);
            _ball.transform.parent = currencyStackPoints[indexBall];
            _ball.transform.position = currencyStackPoints[indexBall].position;
            _ball.BallInStack();
        }

        public void UnstackBalls(BallsMonster unstackMonster)
        {
            if (currencyBalls == null)
                return;

            foreach (var i in currencyBalls)
            {
                i.transform.SetParent(null);
                i.transform.DOMove(transform.position + Vector3.up * 4f, 0.25f);
                i.transform.DOJump(unstackMonster.transform.position, 4, 1, 0.3f).SetDelay(0.15f);
                StartCoroutine(i.IE_BallToMonster(unstackMonster));
                currencyBalls.Remove(i);
            }
        }
    }
}
