using UnityEngine;

namespace Core
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
        [SerializeField] private int lvlCountSmashes;

        #endregion

        public int GetCountSmashes()
        {
            return countSmashes;
        }

        public int GetLevelSmashes()
        {
            return lvlCountSmashes;
        }

        public void AddSmashes(int numberAdd)
        {
            countSmashes += numberAdd;
            lvlCountSmashes++;
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
