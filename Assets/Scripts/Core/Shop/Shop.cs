using System.Collections.Generic;
using UnityEngine;
using AssetKits.ParticleImage;

namespace Core
{
    public class Shop : MonoBehaviour
    {
        #region Variables

        [Header("ShopButtons")]
        [SerializeField] private List<ShopButton> allShopButtons = new List<ShopButton>();
        [SerializeField] private List<ShopButton> pricesShopButtons = new List<ShopButton>();

        [Space]
        [Header("ShopPopup")]
        [SerializeField] private GameObject popup;

        [Space]
        [Header("Effects")]
        [SerializeField] private ParticleImage particleImage;

        [Space]
        [Header("ShopItems")]
        [SerializeField] private ShopItems _shopItems;

        [Space]
        [Header("WeaponSpawner")]
        [SerializeField] private WeaponSpawner _weaponSpawner;

        private ShopButton _shopButton;

        #endregion

        private void Start()
        {
            foreach (var i in allShopButtons)
            {
                i.LoadData();
                CheckButtons(i.GetButtonType());
            }

            _shopItems.ActiveWeaponItem(_weaponSpawner.GetIndex());

            if (BallSkins.Instance.IsBonusSkin())
            {
                _shopItems.ActiveBonusBallsItem(BallSkins.Instance.GetIndex());
                return;
            }

            _shopItems.ActiveBallItem();
        }

        private void FixedUpdate()
        {
           for(int i = 0; i < pricesShopButtons.Count; i++)
           {
                if(MoneyWallet.Instance.GetMoney() >= pricesShopButtons[i].GetPrice())
                {
                    popup.SetActive(true);
                    break;
                }

                popup.SetActive(false);
           }
        }

        private void CheckButtons(ButtonType buttonType)
        {
            int index = 0;

            switch (buttonType)
            {
                case ButtonType.Weapon:
                    index = _weaponSpawner.GetIndex();
                    break;
                case ButtonType.Ball:
                    index = BallSkins.Instance.GetIndex();
                    break;
                case ButtonType.Character:
                    break;
                case ButtonType.BonusBall:
                    index = BallSkins.Instance.GetIndex();
                    break;
            }

            foreach(var i in allShopButtons)
            {
                if(i.GetButtonType() == buttonType)
                    i.CheckButtonStatus(index);
            }
        }

        public void ChangeStat(ButtonType buttonType, int index)
        {
            switch (buttonType)
            {
                case ButtonType.Weapon:
                    _weaponSpawner.SetWeapon(index);
                    _shopItems.ActiveWeaponItem(index);
                    break;
                case ButtonType.Ball:
                    BallSkins.Instance.SetSkin(index);
                    BallSkins.Instance.SetBonusSkin(false);
                    _shopItems.ActiveBallItem();
                    break;
                case ButtonType.Character:
                    _shopItems.ActiveSkin(index);
                    break;
                case ButtonType.BonusBall:
                    BallSkins.Instance.SetSkin(index);
                    BallSkins.Instance.SetBonusSkin(true);
                    _shopItems.ActiveBonusBallsItem(index);
                    break;
            }
            CheckButtons(buttonType);
        }

        public void SetButtonAds(ShopButton shopButton)
        {
            _shopButton = shopButton;
            AdsManager.Instance.ShopReward(this);
        }

        public void ClaimAdsBonus()
        {
            _shopButton.SaleButton();
            CheckButtons(_shopButton.GetButtonType());
        }

        public void ConfettiActive() => particleImage.Play();
    }
}
