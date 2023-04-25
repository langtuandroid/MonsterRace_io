using UnityEngine;
using UnityEngine.UI;
using AssetKits.ParticleImage;

namespace Cor
{
    public class ExtraMoneyButton : MonoBehaviour
    {
        #region Variables

        [SerializeField] GameObject rw;
        [SerializeField] GameObject load;
        [SerializeField] ParticleImage moneyEffect;
        [SerializeField] Text textButton;
        [SerializeField] private int ammountMoney;

        #endregion

        private void Start()
        {
            textButton.text = "+" + ammountMoney;
        }

        private void FixedUpdate()
        {
            if (AdsManager.IsReadyReward)
            {
                rw.SetActive(true);
                load.SetActive(false);
                return;
            }
        }

        public void Click()
        {
            AdsManager.Instance.ExtraMoneyReward(this);
        }

        public void ClaimBonus()
        {
            moneyEffect.gameObject.SetActive(true);
            moneyEffect.OnEnable();
        }
    }
}
