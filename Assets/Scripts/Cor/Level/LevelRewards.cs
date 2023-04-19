using UnityEngine;
using AssetKits.ParticleImage;

namespace Cor
{
    public class LevelRewards : MonoBehaviour
    {
        #region Variables

        [Header("MoneyReward")]
        [SerializeField] private int moneyRewardVictory;
        [SerializeField] private int moneyRewardFailed;

        [Space]
        [Header("ParticlesRewards")]
        [SerializeField] ParticleImage failedEffect;
        [SerializeField] ParticleImage victoryEffect;

        [Space]
        [Header("LockScreen")]
        [SerializeField] GameObject lockScreen;

        [SerializeField] AdsTimer _adsTimer;
        [SerializeField] SceneLoader _sceneLoader;

        #endregion

        public int GetMoneyVictory()
        {
            return moneyRewardVictory;
        }

        public int GetMoneyFailed()
        {
            return moneyRewardFailed;
        }

        private void Start()
        {
            LoadData();
        }

        public void UpdateReward()
        {
            moneyRewardVictory += 25;
            moneyRewardFailed += 10;
            SaveData();
        }

        public void ClaimRewardVictory()
        {
            victoryEffect.gameObject.SetActive(true);
            victoryEffect.SetBurst(0, 0, (moneyRewardVictory - 25) / 5);
            lockScreen.SetActive(true);
        }

        public void ClaimFailedReward()
        {
            failedEffect.gameObject.SetActive(true);
            failedEffect.SetBurst(0, 0, moneyRewardFailed / 5);
            lockScreen.SetActive(true);
        }

        public void ClaimMultiplyReward(int ammountMoney)
        {
            failedEffect.gameObject.SetActive(true);
            failedEffect.SetBurst(0, 0, ammountMoney / 5);
            victoryEffect.gameObject.SetActive(true);
            victoryEffect.SetBurst(0, 0, ammountMoney / 5);
            lockScreen.SetActive(true);
        }

        public void CompletedClaim()
        {
            if(!_adsTimer.isStop)
                if (_adsTimer.IsReadyTimeAd) AdsManager.Instance.ShowInter("win_level");
            _sceneLoader.Loaded(0);
        }

        #region Load&SaveData

        private void LoadData()
        {
            moneyRewardVictory = ES3.Load("moneyRewardVictory", moneyRewardVictory);
            moneyRewardFailed = ES3.Load("moneyRewardFailed", moneyRewardFailed);
        }

        private void SaveData()
        {
            ES3.Save("moneyRewardVictory", moneyRewardVictory);
            ES3.Save("moneyRewardFailed", moneyRewardFailed);
        }

        #endregion
    }
}
