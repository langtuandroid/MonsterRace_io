using System.Collections;
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
        }

        #endregion

        #region Variables

        [SerializeField] List<Color> colorsSkins = new List<Color>();
        [SerializeField] TestLobby testLobby;

        private int indexSkin;

        #endregion

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
            testLobby.ColorBall(colorsSkins[indexSkin]);
            SaveData();
        }

        private void Start()
        {
            LoadData();
            if (testLobby != null) testLobby.ColorBall(colorsSkins[indexSkin]);
        }

        #region Load&SaveData

        private void LoadData()
        {
            indexSkin = ES3.Load("indexSkin", indexSkin);
        }

        private void SaveData()
        {
            ES3.Save("indexSkin", indexSkin);
        }

        #endregion
    }
}
