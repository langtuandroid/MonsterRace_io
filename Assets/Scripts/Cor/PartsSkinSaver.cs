using System.Collections.Generic;
using UnityEngine;

namespace Cor
{
    public class PartsSkinSaver : MonoBehaviour
    {
        [SerializeField] List<string> partsID = new List<string>();
        [SerializeField] List<string> backUp = new List<string>();
        [SerializeField] private int indexID;

        public List<string> GetIDS()
        {
            return partsID;
        }

        private void Awake()
        {
            Load();
        }

        public void AddNewIndex(string _newId, int idList)
        {
            partsID[idList] = _newId;
            Save();
        }

        private void Load()
        {
            partsID = ES3.Load("partsID", partsID);
        }

        private void Save()
        {
            ES3.Save("partsID", partsID);
        }
    }
}
