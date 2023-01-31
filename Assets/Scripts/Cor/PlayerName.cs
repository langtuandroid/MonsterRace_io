using UnityEngine;
using TMPro;

namespace BlueStellar.Cor
{
    public class PlayerName : MonoBehaviour
    {
        [SerializeField] TextMeshProUGUI textName;
        [SerializeField] string playerName;

        public string Name()
        {
            return playerName;
        }

        private void Start()
        {
            LoadSave();
            SetName();
        }

        public void NewName(string name)
        {
            playerName = name;
            SetName();
        }

        private void SetName()
        {
            textName.text = playerName;
            Save();
        }

        #region Save&Load

        private void LoadSave()
        {
            playerName = ES3.LoadString("playerName", playerName);
        }

        private void Save()
        {
            ES3.Save("playerName", playerName);
        }

        #endregion
    }
}
