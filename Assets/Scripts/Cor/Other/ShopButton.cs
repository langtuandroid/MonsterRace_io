using UnityEngine;
using UnityEngine.UI;

namespace Cor
{
    public class ShopButton : MonoBehaviour
    {
        #region Variables

        [Space]
        [Header("IdButton")]
        [SerializeField] private string idButton;

        [Header("Type")]
        [SerializeField] ButtonType _buttonType;

        [Space]
        [Header("BackgroundButton")]
        [SerializeField] Image bg;
        [SerializeField] Color colorOpen;
        [SerializeField] Color colorSelected;

        [Space]
        [Header("TitleButton")]
        [SerializeField] GameObject titlePrice;
        [SerializeField] GameObject titleAds;

        [Space]
        [Header("PriceButton")]
        [SerializeField] Text textPrice;
        [SerializeField] private int price;

        [Space]
        [Header("AdsButton")]
        [SerializeField] Text textAdsCounter;
        [SerializeField] private int ammountAds;
        [SerializeField] private int maxAds;

        [Space]
        [Header("IndexButton")]
        [SerializeField] private int _index;

        [Space]
        [Header("Shop")]
        [SerializeField] Shop _shop;

        [Space]
        [Header("StatusButton")]
        [SerializeField] private bool isAdsButton;
        [SerializeField] private bool isSale;

        #endregion

        #region GetButtonVariables

        public ButtonType GetButtonType()
        {
            return _buttonType;
        }

        public int GetPrice()
        {
            return price;
        }

        public int GetIndexButton()
        {
            return _index;
        }

        #endregion

        private void Start()
        {
            LoadData();
        }

        public void CheckButtonStatus(int index)
        {
            if (!isSale)
            {
                if (!isAdsButton)
                {
                    textPrice.text = price.ToString();
                    return;
                }

                textAdsCounter.text = ammountAds + "/" + maxAds;
                return;
            }

            titlePrice.SetActive(false);
            titleAds.SetActive(false);

            if (_index == index)
            {
                bg.color = colorSelected;
                return;
            }

            bg.color = colorOpen;
        }

        public void ChangeButton()
        {
            if(isSale)
            {
                _shop.ChangeStat(_buttonType, _index);
                return;
            }

            if (!isAdsButton)
            {
                if (MoneyWallet.Instance.Money() >= price)
                {
                    MoneyWallet.Instance.MoneyMinus(price);
                    SaleButton();
                }
                return;
            }

            _shop.SetButtonAds(this);
        }

        public void SaleButton()
        {
            if (isAdsButton)
            {
                ammountAds++;
                SaveData();
                if(ammountAds < maxAds)
                    return;
            }

            if (!isSale)
            {
                isSale = true;
                _shop.ConfettinActive();
                SaveData();
            }

            _shop.ChangeStat(_buttonType, _index);
        }

        #region Load&SaveData

        public void LoadData()
        {
            isSale = ES3.Load("isSale" + idButton, isSale);
            ammountAds = ES3.Load("ammountAds" + idButton, ammountAds);
        }

        private void SaveData()
        {
            ES3.Save("isSale" + idButton, isSale);
            ES3.Save("ammountAds" + idButton, ammountAds);
        }

        #endregion
    }
}
