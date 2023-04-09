using System.Collections.Generic;
using UnityEngine;

namespace Cor
{
    public class SkinsController : MonoBehaviour
    {
        #region Variables

        [SerializeField] List<Skin> currencySkins = new List<Skin>();
        [SerializeField] private int indexOpenSkin;
        [SerializeField] private int indexProgressSkin;

        Skin skin;

        #endregion

        private void Start()
        {
            SetTargetSkin();
        }

        public int OpenSkinMumber()
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
            return skin;
        }

        public void SetTargetSkin()
        {
            Load();
            if(currencySkins.Count > 0)
                skin = currencySkins[indexProgressSkin];
        }

        public void NewProgressSkin()
        {
            indexOpenSkin++;
            indexProgressSkin++;
            if(indexProgressSkin == 6)
            {
                indexProgressSkin = 0;
                for(int i = 0; i < 5; i++)
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
