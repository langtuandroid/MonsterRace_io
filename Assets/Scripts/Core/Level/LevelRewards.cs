using UnityEngine;
using AssetKits.ParticleImage;
using UnityEngine.Serialization;

namespace Core
{
    public class LevelRewards : MonoBehaviour
    {
        #region Variables

        [Header("MoneyReward")]
        [SerializeField] private int moneyRewardVictory;
        [SerializeField] private int moneyRewardFailed;
        
        [Space]
        [Header("ParticlesRewards")]
        [SerializeField] private ParticleImage failedEffect;
        [SerializeField] private ParticleImage victoryEffect;

        [Space]
        [Header("LockScreen")]
        [SerializeField] private GameObject lockScreen;

        [SerializeField] private AdsTimer adsTimer;
        [SerializeField] private SceneLoader sceneLoader;

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

        public void ClaimMultiplyReward(int countMoney)
        {
            failedEffect.gameObject.SetActive(true);
            failedEffect.SetBurst(0, 0, countMoney / 5);
            victoryEffect.gameObject.SetActive(true);
            victoryEffect.SetBurst(0, 0, countMoney / 5);
            lockScreen.SetActive(true);
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
