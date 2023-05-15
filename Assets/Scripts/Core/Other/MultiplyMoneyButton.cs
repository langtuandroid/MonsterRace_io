using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Core
{
    public class MultiplyMoneyButton : MonoBehaviour
    {
        #region Variables

        [SerializeField] Text text;
        [SerializeField] LevelRewards _levelRewards;

        #endregion

        private void Start()
        {
            int bonus = _levelRewards.GetMoneyFailed();
            text.text = bonus * 2 + "";
        }

        public void ChangeMultiply()
        {
            AdsManager.Instance.MultyplyMoneyReward(this);
        }

        public void ClaimMoney()
        {
            _levelRewards.ClaimMultiplyReward(_levelRewards.GetMoneyFailed() * 2);
        }
    }
}
