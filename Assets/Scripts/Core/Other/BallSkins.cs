using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

namespace Core
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

        [SerializeField] private List<Color> colorsSkins = new List<Color>();
        private int _indexSkin;
        private bool _isBonusSkin;

        #endregion

        public bool IsBonusSkin()
        {
            return _isBonusSkin;
        }

        public Color GetColorSkin()
        {
            return colorsSkins[_indexSkin];
        }

        public int GetIndex()
        {
            return _indexSkin;
        }

        public void SetSkin(int index)
        {
            _indexSkin = index;
            SaveData();
        }

        public void SetBonusSkin(bool isBonus)
        {
            _isBonusSkin = isBonus;
            SaveData();
        }

        #region Load&SaveData

        private void LoadData()
        {
            _indexSkin = ES3.Load("indexSkin", _indexSkin);
            _isBonusSkin = ES3.Load("isBonusSkin", _isBonusSkin);
        }

        private void SaveData()
        {
            ES3.Save("indexSkin", _indexSkin);
            ES3.Save("isBonusSkin", _isBonusSkin);
        }

        #endregion
    }
}
