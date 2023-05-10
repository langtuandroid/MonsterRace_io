using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using DG.Tweening;
using AssetKits.ParticleImage;

namespace Cor
{
    public class RatingLeaderboard : MonoBehaviour
    {
        #region Variables

        [SerializeField] List<RatingMember> currencyMembers = new List<RatingMember>();
        [SerializeField] List<Transform> pointsRating = new List<Transform>();
        [SerializeField] Transform group;
        [SerializeField] Transform view;
        [SerializeField] Vector3[] posViews;
        [SerializeField] ParticleImage effectSkull;
        [SerializeField] RatingMenu ratingMenu;

        public static bool isCompletedFight;

        #endregion

        private void Awake()
        {
            if (!isCompletedFight) ratingMenu.Play();
        }

        private void Start()
        {
            SetupMembers();
           
            if (isCompletedFight)
            {
                ChangeSmashes();
                SortMembers();
                return;
            }
        }

        public void ScrollAnimation()
        {
            group.DOLocalMoveY(-5390f, 0.8f).OnComplete(() =>
               DOVirtual.DelayedCall(1.5f, () => group.DOLocalMoveY(407f, 0.8f)));
        }

        private void ChangeSmashes()
        {
            foreach(var i in currencyMembers)
            {
                if (!i.IsPlayerMemeber()) i.AddSmashes(Random.Range(0, 3));
                if (i.IsPlayerMemeber())
                {
                    int ammountSmashes = PlayerSmashes.Instance.GetCountSmashes() - i.GetSmashes();
                    i.AddSmashes(ammountSmashes);
                    if(ammountSmashes > 0)
                    {
                        effectSkull.SetBurst(0, 0.1f, ammountSmashes);
                        effectSkull.Play();
                    }
                }
            }
        }

        private void SortMembers()
        {
            currencyMembers = currencyMembers.OrderByDescending(i => i.GetSmashes()).ToList();
            for (int i = 0; i < currencyMembers.Count; i++)
            {
                currencyMembers[i].SetNumberRating(i + 1);
                if (!currencyMembers[i].IsPlayerMemeber())
                {
                    currencyMembers[i].transform.DOMoveY(pointsRating[i].position.y, 0.3f);
                }
                if (currencyMembers[i].IsPlayerMemeber())
                {
                    currencyMembers[i].AnimationMember(pointsRating[i]);
                    //ScrollView(currencyMembers[i]);
                }
            }
        }

        private void SetupMembers()
        {
            foreach (var i in currencyMembers) i.SetupMemberSmashes();
            foreach (var i in currencyMembers) i.SetupMemberRating();
            RatingMember ratingMember = null;
            foreach (var i in currencyMembers) {
                if (i.IsPlayerMemeber())
                {
                    ratingMember = i;
                    break;
                }
            }
            Vector3 dir = view.transform.localPosition;
            dir.y = posViews[ratingMember.GetRating()].y;
            view.transform.localPosition = dir;
            currencyMembers = currencyMembers.OrderByDescending(i => i.GetSmashes()).ToList();
            for (int i = 0; i < currencyMembers.Count; i++)
            {
                currencyMembers[i].transform.position = pointsRating[i].position;
            }
        }

        private void ScrollView(RatingMember ratingMember)
        {
            //Vector3 dir = view.transform.localPosition;
            //dir.y = posViews[ratingMember.GetRating()].y;
            //view.transform.DOLocalMoveY(dir.y, 0.8f).SetDelay(0.7f);
        }
    }
}
