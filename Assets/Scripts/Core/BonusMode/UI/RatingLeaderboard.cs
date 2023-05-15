using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using DG.Tweening;
using AssetKits.ParticleImage;

namespace Core
{
    public class RatingLeaderboard : MonoBehaviour
    {
        #region Variables

        [SerializeField] private List<RatingMember> currencyMembers;
        [SerializeField] private List<Transform> pointsRating;
        [SerializeField] private Transform group;
        [SerializeField] private Transform view;
        [SerializeField] private Vector3[] posViews;
        [SerializeField] private ParticleImage _effectSkull;
        [SerializeField] private RatingMenu ratingMenu;

        public static bool IsCompletedFight;

        #endregion

        private void Start()
        {
            SetupMembers();


            if (!IsCompletedFight) ratingMenu.Play();

            if (IsCompletedFight)
            {
                ChangeSmashes();
                SortMembers();
                IsCompletedFight = false;
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
                if (!i.IsPlayerMember()) i.AddSmashes(Random.Range(0, 3));
                if (i.IsPlayerMember())
                {
                    var countSmashes = PlayerSmashes.Instance.GetCountSmashes() - i.GetSmashes();
                    i.AddSmashes(countSmashes);
                    if (countSmashes <= 0) 
                        return;
                    _effectSkull.SetBurst(0, 0.1f, countSmashes);
                    _effectSkull.Play();
                }
            }
        }

        private void SortMembers()
        {
            currencyMembers = currencyMembers.OrderByDescending(i => i.GetSmashes()).ToList();
            for (var i = 0; i < currencyMembers.Count; i++)
            {
                currencyMembers[i].SetNumberRating(i + 1);
                if (!currencyMembers[i].IsPlayerMember())
                {
                    currencyMembers[i].transform.DOMoveY(pointsRating[i].position.y, 0.3f);
                }
                if (currencyMembers[i].IsPlayerMember())
                {
                    currencyMembers[i].AnimationMember(pointsRating[i]);
                }
            }

            if (!IsCompletedFight) ratingMenu.Play();
        }

        private void SetupMembers()
        {
            foreach (var i in currencyMembers) i.SetupMemberSmashes();
            foreach (var i in currencyMembers) i.SetupMemberRating();
            RatingMember ratingMember = null;
            foreach (var i in currencyMembers)
            {
                if (i.IsPlayerMember())
                {
                    ratingMember = i;
                    break;
                }
            }

            Vector3 dir = view.transform.localPosition;
            if (ratingMember != null) 
                dir.y = posViews[ratingMember.GetRating()].y;
            view.transform.localPosition = dir;
            currencyMembers = currencyMembers.OrderByDescending(i => i.GetSmashes()).ToList();
            for (var i = 0; i < currencyMembers.Count; i++)
            {
                currencyMembers[i].transform.position = pointsRating[i].position;
            }
        }
    }
}
