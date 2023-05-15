using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
using UnityEngine.Serialization;

namespace Core
{
    public class LoseScreen : MonoBehaviour
    {
        #region Variables

        [SerializeField] private GameObject header;
        [SerializeField] private GameObject bonusButton;
        [SerializeField] private GameObject skipButton;
        [SerializeField] private GameObject bottom;
        [SerializeField] private Text textCounter;
        [SerializeField] private LevelRewards levelRewards;

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
            if(levelRewards != null)
                textCounter.text = levelRewards.GetMoneyFailed() + "$ " + "is enought";
        }
    }
}
