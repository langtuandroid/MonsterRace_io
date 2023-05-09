using UnityEngine;

namespace Cor
{
    public class PlayerSmashes : MonoBehaviour
    {
        #region Singelton

        public static PlayerSmashes Instance;

        private void Awake()
        {
            Instance = this;
            LoadData();
        }


        #endregion

        #region Variables

        [SerializeField] private int countSmashes;

        #endregion

        public int GetCountSmashes()
        {
            return countSmashes;
        }

        public void AddSmashes(int numberAdd)
        {
            countSmashes += numberAdd;
            SaveData();
        }

        #region Load&SaveData

        private void LoadData()
        {
            countSmashes = ES3.Load("countSmashes", countSmashes);
        }

        private void SaveData()
        {
            ES3.Save("countSmashes", countSmashes);
        }

        #endregion
    }
}
