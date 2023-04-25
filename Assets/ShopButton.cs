using UnityEngine;
using UnityEngine.UI;
using AssetKits.ParticleImage;

namespace Cor
{
    public class ShopButton : MonoBehaviour
    {
        #region Variables

        [Header("IdButton")]
        [SerializeField] private int idButton;

        [Header("BackgroundButton")]
        [SerializeField] Image bg;
        [SerializeField] Color colorDeselect;
        [SerializeField] Color colorOpen;
        [SerializeField] Color chooseColor;

        [Header("TitleButton")]
        [SerializeField] GameObject titlePrice;
        [SerializeField] GameObject titleAds;

        [Header("StatusButton")]
        [SerializeField] private bool isBall;
        [SerializeField] private bool isWeapon;
        [SerializeField] private bool isSale;

        public ParticleImage particleImage;

        private WeaponSpawner weaponSpawner;

        #endregion

        private void Start()
        {
            LoadData();
            if (isWeapon) weaponSpawner = GameObject.FindObjectOfType<WeaponSpawner>();
            CheckButtonStatus();
        }

        private void FixedUpdate()
        {
            CheckButtonStatus();
        }

        public void Buy()
        {
            if(isSale)
            {
                Open();
                return;
            }

            if (MoneyWallet.Instance.Money() >= 3000)
            {
                MoneyWallet.Instance.MoneyMinus(3000);
                particleImage.Play();

                Open();
            }
        }

        public void ForAds()
        {
            if (isSale)
            {
                Open();
                return;
            }

            AdsManager.Instance.ShopReward(this);
        }

        public void Open()
        {
            if (!isSale)
            {
                isSale = true;
                SaveData();
            }
            if (isWeapon)
                weaponSpawner.SetWeapon(idButton);
            if (isBall)
                BallSkins.Instance.SetSkin(idButton);
        }

        private void CheckButtonStatus()
        {
            if (isWeapon && isSale)
            {
                bg.color = colorOpen;
                if (idButton == weaponSpawner.GetIndex())
                    bg.color = chooseColor;
            }

            if (isBall && isSale)
            {
                bg.color = colorOpen;
                if (idButton == BallSkins.Instance.GetIndex())
                    bg.color = chooseColor;
            }

            if (!isSale)
                return;

            titlePrice.SetActive(false);
            titleAds.SetActive(false);
        }

        #region Load&SaveData

        private void LoadData()
        {
            isSale = ES3.Load("isSale" + idButton, isSale);
        }

        private void SaveData()
        {
            ES3.Save("isSale" + idButton, isSale);
        }

        #endregion
    }
}
