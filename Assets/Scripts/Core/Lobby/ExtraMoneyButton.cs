using System.Net.NetworkInformation;
using UnityEngine;
using UnityEngine.UI;
using AssetKits.ParticleImage;
using UnityEngine.Serialization;

namespace Core
{
    public class ExtraMoneyButton : MonoBehaviour
    {
        #region Variables

        [SerializeField] private GameObject rw;
        [SerializeField] private GameObject load;
        [SerializeField] private ParticleImage moneyEffect;
        [SerializeField] private Text textButton;
        [SerializeField] private int countMoney;

        #endregion

        private void Start() => textButton.text = "+" + countMoney;
      
        private void FixedUpdate()
        {
            if (!AdsManager.IsReadyReward)
                return;
            
            rw.SetActive(true);
            load.SetActive(false);
        }

        public void ClaimBonus()
        {
            moneyEffect.Stop();
            moneyEffect.Play();
        }
        
        public void Click() =>  AdsManager.Instance.ExtraMoneyReward(this);
    }
}
