using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;

namespace Core
{
    public class BonusButton : MonoBehaviour
    {
        #region Variables
        
        [SerializeField] private LevelRewards levelRewards;
        [SerializeField] private BonusArrow bonusArrow;
        [SerializeField] private Text moneyCounter;
        [SerializeField] private int amountBonus;

        #endregion

        public void SetBonus(int number)
        {
            if (LevelManager.Instance.GetGameMode() == GameModeType.Game)
                amountBonus = levelRewards.GetMoneyVictory() * number;
            if (LevelManager.Instance.GetGameMode() == GameModeType.Bonus)
            {
                var rewardAmmount = PlayerSmashes.Instance.GetLevelSmashes();
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
            bonusArrow.StopArrow();
            AdsManager.Instance.BonusMoneyReward(this);
        }

        public void ClaimBonus()
        {
            if (LevelManager.Instance.GetGameMode() == GameModeType.Game)
            {
                levelRewards.ClaimMultiplyReward(amountBonus);
                return;
            }

            PlayerSmashes.Instance.AddSmashes(amountBonus);
            LevelManager.Instance.ExitLevel(2);
        }
    }
}
