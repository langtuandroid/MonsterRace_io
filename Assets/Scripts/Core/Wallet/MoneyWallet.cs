using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
using UnityEngine.Serialization;

namespace Core
{
    public class MoneyWallet : MonoBehaviour
    {
        #region Singelton

        public static MoneyWallet Instance;

        private void Awake()
        {
            Instance = this;
        }

        #endregion

        #region Variables

        [SerializeField] private Text textCountMoney;
        [SerializeField] private int countMoney;

        #endregion

        public int GetMoney()
        {
            return countMoney;
        }

        private void Start()
        {
            LoadSave();
            MoneyText(textCountMoney, countMoney);
        }

        public void MoneyPlus(int number)
        {
            countMoney += number;
            MoneyText(textCountMoney, countMoney);
            Save();
        }

        public void MoneyMinus(int number)
        {
            countMoney -= number;
            MoneyText(textCountMoney, countMoney);
            Save();
        }

        private void MoneyText(Text textMoney, int money)
        {
            if (textMoney == null)
                return;

            switch (money)
            {
                case < 10:
                    textMoney.text = money.ToString().Substring(0, 1);
                    return;
                case < 100:
                    textMoney.text = money.ToString().Substring(0, 2);
                    return;
                case < 1000:
                    textMoney.text = money.ToString().Substring(0, 3);
                    return;
                default:
                    textMoney.text = GetSuffixValue(money);
                    break;
            }
        }

        string GetSuffixValue(float value)
        {
            var zero = 0;

            while (value >= 1000)
            {
                ++zero;

                value /= 1000;
            }

            var suffix = string.Empty;

            switch (zero)
            {
                case 0: suffix = ""; break;
                case 1: suffix = "K"; break;
                case 2: suffix = "M"; break;
                case 3: suffix = "B"; break;
                case 4: suffix = "T"; break;
                case 5: suffix = "Qd"; break;
                case 6: suffix = "Qn"; break;
                case 7: suffix = "Sx"; break;
                case 8: suffix = "Sp"; break;
                case 9: suffix = "Oc"; break;
            }

            return $"{value:0.##}{suffix}";
        }

        #region Load&Save

        private void LoadSave()
        {
            countMoney = ES3.Load("ammountMoney", countMoney);
        }

        private void Save()
        {
            ES3.Save("ammountMoney", countMoney);
        }

        #endregion
    }
}