using UnityEngine;
using UnityEngine.UI;

namespace Cor
{
    public class BonusButton : MonoBehaviour
    {
        #region Variables

        [SerializeField] GameModeType gameModeType;
        [SerializeField] LevelRewards _levelRewards;
        [SerializeField] BonusArrow _bonusArrow;
        [SerializeField] Text moneyCounter;
        [SerializeField] private int amountBonus;

        #endregion

        public void SetBonus(int number)
        {
            if (gameModeType == GameModeType.Game)
                amountBonus = _levelRewards.GetMoneyVictory() * number;
            if (gameModeType == GameModeType.Bonus)
            {
                int rewardAmmount = PlayerSmashes.Instance.GetLevelSmashes();
                if (rewardAmmount == 0)
                {
                    rewardAmmount = 1;
                }
                amountBonus = rewardAmmount * number;
            }
            moneyCounter.text = amountBonus.ToString();
        }

        public void ChangeBonus()
        {
            _bonusArrow.StopArrow();
            AdsManager.Instance.BonusMoneyReward(this);
        }

        public void ClaimBonus()
        {
            if (gameModeType == GameModeType.Game)
            {
                _levelRewards.ClaimMultiplyReward(amountBonus);
                return;
            }

            PlayerSmashes.Instance.AddSmashes(amountBonus);
            LevelManager.Instance.ReloadBonusMode();
        }
    }
}
