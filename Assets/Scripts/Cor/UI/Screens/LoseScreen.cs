using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

namespace Cor
{
    public class LoseScreen : MonoBehaviour
    {
        #region Variables

        [SerializeField] GameObject header;
        [SerializeField] GameObject bonusButton;
        [SerializeField] GameObject skipButton;
        [SerializeField] GameObject bottom;
        [SerializeField] Text textCounter;
        [SerializeField] LevelRewards _levelRewards;

        #endregion

        private void Start()
        {
            ActiveScreen();    
        }

        private void ActiveScreen() 
        {
            header.transform.DOScale(header.transform.localScale, 0.5f).From(0).SetEase(Ease.Linear);
            if(bonusButton != null)
                bonusButton.transform.DOScale(bonusButton.transform.localScale, 0.5f).From(0).SetEase(Ease.Linear).SetDelay(0.3f);
            if(skipButton != null)
                skipButton.transform.DOScale(skipButton.transform.localScale, 0.5f).From(0).SetEase(Ease.Linear).SetDelay(0.35f);
            bottom.transform.DOScale(bottom.transform.localScale, 0.5f).From(0).SetEase(Ease.Linear).SetDelay(3f);
            if(_levelRewards != null)
                textCounter.text = _levelRewards.GetMoneyFailed() + "$ " + "is enought";
        }
    }
}
