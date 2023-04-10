using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Cor
{
    public class AdsTimer : MonoBehaviour
    {
        #region Variables

        [SerializeField] private float timer;
        [SerializeField] private float timeToShow;
        [SerializeField] private bool isBlockTimer;

        #endregion

        private void Start()
        {
            LevelManager.Instance.OnLevelStart.AddListener(StartTimer);
            LevelManager.Instance.OnLevelContinue.AddListener(RestartTimer);
            LevelManager.Instance.OnLevelEnd.AddListener(CloseTimer);
        }

        private void FixedUpdate()
        {
            if (isBlockTimer)
                return;

            timer += Time.deltaTime;

            if(timer >= timeToShow)
            {
                AdsManager.Instance.LoadInterstitial();
                timer = 0;
                isBlockTimer = true;
            }
        }

        private void StartTimer()
        {
            isBlockTimer = false;
        }

        private void RestartTimer()
        {
            isBlockTimer = false;
        }

        private void CloseTimer()
        {
            isBlockTimer = true;
        }
    }
}
