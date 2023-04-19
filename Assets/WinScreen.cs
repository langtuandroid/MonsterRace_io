using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

namespace Cor
{
    public class WinScreen : MonoBehaviour
    {
        #region Variables

        [SerializeField] GameObject header;
        [SerializeField] GameObject[] stars;
        [SerializeField] GameObject bonusTitle;
        [SerializeField] GameObject bottomTitle;
        [SerializeField] Text textEnought;
        [SerializeField] LevelRewards _levelRewards;

        #endregion

        public void ActiveScreen()
        {
            UIManager.Instance.BonusScreen(false);
            UIManager.Instance.MoneyScreen(true);
            UIManager.Instance.RewardScreen(true);
            header.transform.DOScale(header.transform.localScale, 0.5f).From(0).SetEase(Ease.Linear);
            float dilay = 0.2f;
            for(int i = 0; i < stars.Length; i++)
            {
                stars[i].transform.DOScale(stars[i].transform.localScale, 0.5f).From(0).SetEase(Ease.Linear).SetDelay(dilay);
                dilay += 0.2f;
            }
            bonusTitle.transform.DOLocalMoveY(0, 0.5f).From(-1567f).SetEase(Ease.Linear).SetDelay(1f);
            bottomTitle.transform.DOScale(bottomTitle.transform.localScale, 0.5f).From(0).SetDelay(3f);
            textEnought.text = (_levelRewards.GetMoneyVictory() - 25) + "$ " + "is enought";
        }
    }
}
