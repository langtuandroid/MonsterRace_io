using System.Collections.Generic;
using UnityEngine;

namespace Core
{
    public class SkinsController : MonoBehaviour
    {
        #region Variables
        
        [SerializeField] private List<Skin> currencySkins = new List<Skin>();
        [SerializeField] private int indexOpenSkin;
        [SerializeField] private int indexProgressSkin;

        private Skin _skin;

        #endregion

        private void Start()
        {
            SetTargetSkin();
        }

        public int OpenSkinMember()
        {
            Load();
            return indexOpenSkin;
        }

        public int GetIndexProgress()
        {
            Load();
            return indexProgressSkin;
        }

        public Skin GetProgressSkin()
        {
            return _skin;
        }
        
        public void NewProgressSkin()
        {
            indexOpenSkin++;
            indexProgressSkin++;
            if(indexProgressSkin == 8)
            {
                indexProgressSkin = 0;
                for(int i = 0; i < 7; i++)
                {
                    currencySkins[i].CloseSkin();
                }
            }
            if(indexProgressSkin == 1)
            {
                indexOpenSkin = 0;
                currencySkins[currencySkins.Count - 1].CloseSkin();
            }
            Save();
        }

        public void OpenPart()
        {
            currencySkins[indexProgressSkin].AddSkinPart();
        }

        public void BonusPart()
        {
            currencySkins[indexProgressSkin].AddSkinPart();
            currencySkins[indexProgressSkin].OpenFramgentSkin();
        }
        
        private void SetTargetSkin()
        {
            Load();
            if(currencySkins.Count > 0)
                _skin = currencySkins[indexProgressSkin];
        }

        #region Load&Save

        private void Save()
        {
            ES3.Save("indexOpenSkin", indexOpenSkin);
            ES3.Save("indexProgressSkin", indexProgressSkin);
        }

        private void Load()
        {
            indexOpenSkin = ES3.Load("indexOpenSkin", indexOpenSkin);
            indexProgressSkin = ES3.Load("indexProgressSkin", indexProgressSkin);
        }

        #endregion
    }
}
