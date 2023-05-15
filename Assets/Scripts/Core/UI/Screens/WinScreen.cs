using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

namespace Core
{
    public class WinScreen : MonoBehaviour
    {
        #region Variables

        [SerializeField] private GameObject header;
        [SerializeField] private GameObject[] stars;
        [SerializeField] private GameObject bonusTitle;
        [SerializeField] private GameObject bottomTitle;
        [SerializeField] private Text textEnought;
        [SerializeField] private LevelRewards _levelRewards;

        #endregion

        private void Start()
        {
            if(_levelRewards == null)
                ActiveScreen();
        }

        public void ActiveScreen()
        {
            UIManager.Instance.BonusScreen(false);
            UIManager.Instance.MoneyScreen(true);
            UIManager.Instance.RewardScreen(true);
            header.transform.DOScale(header.transform.localScale, 0.5f).From(0).SetEase(Ease.Linear);
            var dilay = 0.2f;
            for(var i = 0; i < stars.Length; i++)
            {
                stars[i].transform.DOScale(stars[i].transform.localScale, 0.5f).From(0).SetEase(Ease.Linear).SetDelay(dilay);
                dilay += 0.2f;
            }
            bonusTitle.transform.DOLocalMoveY(0, 0.5f).From(-1567f).SetEase(Ease.Linear).SetDelay(1f);
            bottomTitle.transform.DOScale(bottomTitle.transform.localScale, 0.5f).From(0).SetDelay(3f);
            if(_levelRewards != null)
                textEnought.text = (_levelRewards.GetMoneyVictory() - 25) + "$ " + "is enought";
        }
    }
}
