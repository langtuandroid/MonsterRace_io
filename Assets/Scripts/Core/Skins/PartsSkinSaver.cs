using System.Collections.Generic;
using UnityEngine;

namespace Core
{
    public class PartsSkinSaver : MonoBehaviour
    {
        #region Variables
        
        [SerializeField] private List<string> partsID = new List<string>();
        [SerializeField] private List<string> backUp = new List<string>();

        #endregion
        
        public List<string> GetIDS()
        {
            return partsID;
        }

        private void Awake()
        {
            LoadData();
        }

        public void AddNewID(string newId)
        {
            partsID.Add(newId);
            SaveData();
        }

        #region Load&SaveData

        private void LoadData()
        {
            partsID = ES3.Load("partsID", partsID);
        }

        private void SaveData()
        {
            ES3.Save("partsID", partsID);
        }

        #endregion
    }
}
