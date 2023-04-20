using System;
using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;

namespace Cor
{
    public class AdsTimer : MonoBehaviour
    {
        #region Variables

        [SerializeField] GameObject screenTimer;
        [SerializeField] Slider sliderTimer;
        [SerializeField] Text textCouter;
        [SerializeField] private float timer;
        [SerializeField] private float timeToShow;
        [SerializeField] private bool isShowTimer;
        [SerializeField] private bool isBlockTimer;
        [SerializeField] private bool isResultAds;

        public bool isStop;
        public bool IsReadyTimeAd { get; set; }
      
        #endregion

        private void Start()
        {
            LevelManager.Instance.OnLevelStart.AddListener(StartTimer);
            LevelManager.Instance.OnLevelContinue.AddListener(RestartTimer);
            LevelManager.Instance.OnLevelEnd.AddListener(ResultReward);
            AdsManager.StopedTimer += StopTimerAction;
        }

        private void FixedUpdate()
        {
            if (LevelManager.Instance.LvlNumber() == 1)
                return;

            if (!isResultAds)
            {
                if (isBlockTimer)
                    return;

                timer -= Time.deltaTime;

                if (timer <= 6)
                {
                    if (!isShowTimer)
                    {
                        screenTimer.SetActive(true);
                        screenTimer.transform.DOScale(1, 0.5f).From(0);
                        isShowTimer = true;
                    }
                }

                if (timer <= 0)
                {
                    CloseTimer();
                    AdsManager.Instance.ShowInter("play_level");
                }

                if (!isShowTimer)
                    return;

                textCouter.text = "0:0" + (int)timer;
                sliderTimer.value = timer;
                return;
            }

            if (IsReadyTimeAd)
                return;

            timer -= Time.deltaTime;
            if (timer <= 0)
            {
                IsReadyTimeAd = true;
            }
        }

        public void StopTimerAction()
        {
            isStop = true;
        }

        private void StartTimer()
        {
            isBlockTimer = false;
        }

        private void RestartTimer()
        {
            isBlockTimer = false;
        }

        private void ResultReward()
        {
            if (screenTimer.activeSelf)
                screenTimer.transform.DOScale(0, 0.5f).OnComplete(() => screenTimer.SetActive(false));
            isResultAds = true;
        }

        private void CloseTimer()
        {
            if (screenTimer.activeSelf)
                screenTimer.transform.DOScale(0, 0.5f).OnComplete(() => screenTimer.SetActive(false));

            timer = 30;
            isShowTimer = false;
            isBlockTimer = true;
        }
    }
}
