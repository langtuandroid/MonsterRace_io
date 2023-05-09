using UnityEngine;
using DG.Tweening;

namespace Cor
{
    public class AnonserTutorialScreen : MonoBehaviour
    {
        #region Variables

        [SerializeField] GameObject headerTitle;
        [SerializeField] GameObject timerTitle;
        [SerializeField] GameObject skinTitle;
        [SerializeField] GameObject bottomTitle;
        [SerializeField] GameObject goButton;
        [SerializeField] Transform  targetTitle;
        [SerializeField] RatingMenu ratingMenu;

        #endregion

        public void ActiveScreen()
        {
            gameObject.SetActive(true);
            headerTitle.transform.DOScale(headerTitle.transform.localScale, 0.5f).From(0);
            timerTitle.transform.DOScale(timerTitle.transform.localScale, 0.5f).From(0).SetDelay(0.2f);
            skinTitle.transform.DOScale(skinTitle.transform.localScale, 0.5f).From(0).SetDelay(0.5f);
            bottomTitle.transform.DOScale(bottomTitle.transform.localScale, 0.5f).From(0).SetDelay(1f);
            goButton.transform.DOScale(goButton.transform.localScale, 0.5f).From(0).SetDelay(2f).OnComplete(() =>
            goButton.transform.DOPunchScale(new Vector3(0.1f, 0.1f, 0.1f), 1f, 1).SetEase(Ease.Linear).SetLoops(-1));
        }   
        
        public void DeactiveScreen()
        {
            skinTitle.transform.parent = targetTitle.transform.parent;
            skinTitle.transform.DOJump(targetTitle.position, 5, 1, 1f);
            skinTitle.transform.DOScale(targetTitle.transform.localScale, 1f);
            ratingMenu.FirstOpen();
            gameObject.SetActive(false);
        }
    }
}
