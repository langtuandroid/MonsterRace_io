using UnityEngine;
using DG.Tweening;

namespace Core
{
    public class AnonserScreen : MonoBehaviour
    {
        #region Variables

        [SerializeField] private GameObject headerTitle;
        [SerializeField] private GameObject rewardTitle;
        [SerializeField] private GameObject bottomTitle;

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
