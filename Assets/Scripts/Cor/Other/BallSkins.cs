using System.Collections.Generic;
using UnityEngine;

namespace Cor
{
    public class BallSkins : MonoBehaviour
    {
        #region Singelton

        public static BallSkins Instance;

        private void Awake()
        {
            Instance = this;
            LoadData();
        }

        #endregion

        #region Variables

        [SerializeField] List<Color> colorsSkins = new List<Color>();
        private int indexSkin;
        public bool isBonusSkin;

        #endregion

        public bool IsBonusSkin()
        {
            return isBonusSkin;
        }

        public Color GetColorSkin()
        {
            return colorsSkins[indexSkin];
        }

        public int GetIndex()
        {
            return indexSkin;
        }

        public void SetSkin(int index)
        {
            indexSkin = index;
            SaveData();
        }

        public void SetBonusSkin(bool isBonus)
        {
            isBonusSkin = isBonus;
            SaveData();
        }

        #region Load&SaveData

        private void LoadData()
        {
            indexSkin = ES3.Load("indexSkin", indexSkin);
            isBonusSkin = ES3.Load("isBonusSkin", isBonusSkin);
        }

        private void SaveData()
        {
            ES3.Save("indexSkin", indexSkin);
            ES3.Save("isBonusSkin", isBonusSkin);
        }

        #endregion
    }
}
