using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

namespace PlayKing.Cor
{
    public class StackBalls : MonoBehaviour
    {
        [SerializeField] List<CollectableBall> currencyBalls = new List<CollectableBall>();

        public void AddCollectableBall(CollectableBall _ball)
        {
            currencyBalls.Add(_ball);
            _ball.BallInStack();
        }

        public void UnstackBalls(Transform unstackPoint)
        {
            if (currencyBalls == null)
                return;

            foreach (var i in currencyBalls)
            {
                i.transform.SetParent(null);
                i.transform.DOMove(transform.position + Vector3.up * 4f, 0.25f);
                i.transform.DOJump(unstackPoint.transform.position, 4, 1, 0.3f).SetDelay(0.15f);
                
                currencyBalls.Remove(i);
            }
        }
    }
}
