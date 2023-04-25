using UnityEngine;
using UnityEngine.UI;

namespace Cor
{
    public class BonusButton : MonoBehaviour
    {
        #region Variables

        [SerializeField] LevelRewards _levelRewards;
        [SerializeField] BonusArrow _bonusArrow;
        [SerializeField] Text moneyCounter;
        [SerializeField] private int amountBonus;

        #endregion

        public void SetBonus(int number)
        {
            amountBonus = _levelRewards.GetMoneyVictory() * number;
            moneyCounter.text = amountBonus.ToString();
        }

        public void ChangeBonus()
        {
            _bonusArrow.StopArrow();
            AdsManager.Instance.BonusMoneyReward(this);
        }

        public void ClaimBonus()
        {
            _levelRewards.ClaimMultiplyReward(amountBonus);
        }
    }
}
