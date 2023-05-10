using UnityEngine;
using DG.Tweening;

namespace Cor
{
    public class AnonserScreen : MonoBehaviour
    {
        #region Variables

        [SerializeField] GameObject headerTitle;
        [SerializeField] GameObject rewardTitle;
        [SerializeField] GameObject bottomTitle;
        [SerializeField] RatingRewards ratingRewards;

        #endregion

        public void ActiveScreen()
        {
            gameObject.SetActive(true);
            headerTitle.transform.DOPunchScale(new Vector3(0.1f, 0.1f, 0.1f), 0.7f, 3).SetEase(Ease.Linear);
            rewardTitle.transform.DOScale(rewardTitle.transform.localScale, 0.5f).From(0).SetDelay(0.25f);
            bottomTitle.transform.DOScale(bottomTitle.transform.localScale, 0.5f).From(0).SetDelay(0.8f);
        }

        public void DeactiveScreen()
        {
            gameObject.SetActive(false);
        }
    }
}
