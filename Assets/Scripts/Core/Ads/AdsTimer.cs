using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;

namespace Core
{
    public class AdsTimer : MonoBehaviour
    {
        #region Variables

        [SerializeField] private GameObject screenTimer;
        [SerializeField] private Slider _sliderTimer;
        [SerializeField] private Text _textCouter;
        [SerializeField] private float timer;
        [SerializeField] private float timeToShow;
        [SerializeField] private bool isShowTimer;
        [SerializeField] private bool isBlockTimer;
        [SerializeField] private bool isResultAds;

        public bool isStop;
        private bool IsReadyTimeAd { get; set; }
      
        #endregion

        private void Start()
        {
            LevelManager.Instance.OnLevelStart += StartTimer;
            LevelManager.Instance.OnLevelContinue += RestartTimer;
            LevelManager.Instance.OnLevelEnd += ResultReward;
            LevelManager.Instance.OnLevelReload += Show;
            AdsManager.Instance.OnStopTimer += StopTimerAction;
        }

        private void FixedUpdate()
        {
            CheckedTimer();
        }

        private void StopTimerAction() => isStop = true;

        private void StartTimer() => isBlockTimer = false;

        private void RestartTimer() => isBlockTimer = false;

        private void Show()
        {
            if (isStop && !IsReadyTimeAd) 
                return;
            
            AdsManager.Instance.ShowInter("win_level");
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

            timer = timeToShow;
            isShowTimer = false;
            isBlockTimer = true;
        }

        private void CheckedTimer()
        {
            if (LevelManager.Instance.GetLvlNumber() == 1)
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

                _textCouter.text = "0:0" + (int)timer;
                _sliderTimer.value = timer;
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
    }
}
