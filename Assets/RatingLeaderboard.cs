using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

namespace Cor
{
    public class RatingLeaderboard : MonoBehaviour
    {
        #region Variables

        [SerializeField] List<RatingMember> currencyMembers = new List<RatingMember>();
        [SerializeField] List<RatingMember> test = new List<RatingMember>();
        [SerializeField] List<Transform> pointsRating = new List<Transform>();
        [SerializeField] Transform group;

        #endregion

        private void Start()
        {
            SortMembers();
        }

        private void Update()
        {
            if (Input.GetKeyDown("s"))
            {
                SortMembers();
            }

            if (Input.GetKeyDown("d"))
            {
                AddSmashes();
            }
        }

        public void ScrollAnimation()
        {
            group.DOLocalMoveY(-5376f, 0.8f).OnComplete(() =>
               DOVirtual.DelayedCall(1.5f, () => group.DOLocalMoveY(407f, 0.8f)));
        }

        private void AddSmashes()
        {
            foreach(var i in currencyMembers)
            {
                i.SetSmashes(Random.Range(1, 8));
            }
        }

        private void SortMembers()
        {
            test = currencyMembers.OrderByDescending(i => i.GetSmashes()).ToList();
            for (int i = 0; i < test.Count; i++)
            {
                test[i].SetNumberRating(i + 1);
                if (!test[i].IsPlayerMemeber())
                {
                    test[i].transform.DOMoveY(pointsRating[i].position.y, 0.3f);
                }
            }
        }
    }
}
