using System.Collections;
using UnityEngine;
using UnityEngine.Events;
using TMPro;

namespace PlayKing.Cor
{
    public class LevelController : MonoBehaviour
    {
        #region Singelton

        public static LevelController Instance;

        private void Awake()
        {
            Instance = this;
            NewLevel();
        }

        #endregion

        [SerializeField] LevelSpawner levelSpawner;
        [SerializeField] TextMeshProUGUI textLvlNumber;
        [SerializeField] private int lvlNumber;
        [SerializeField] private bool isEditor;
        private int lvlIndex;

        [HideInInspector]
        public UnityEvent OnLevelStart;
        [HideInInspector]
        public UnityEvent OnLevelEnd;

        public int LvlNumber()
        {
            return lvlNumber;
        }

        public void LevelStart()
        {
            OnLevelStart.Invoke();
            UIManager.Instance.TutorialScreen(false);   
            UIManager.Instance.StartScreen(false);
            UIManager.Instance.MoneyScreen(false);
            UIManager.Instance.PointerScreen(true);
            UIManager.Instance.LeaderboardScreen(true);
        }

        public void LevelCompleted()
        {
            LevelEnd();
            StartCoroutine(IE_WinUI());
        }

        public void LevelFailed()
        {
            LevelEnd();
            UIManager.Instance.LoseScreen(true);
        }

        private void LevelEnd()
        {
            OnLevelEnd.Invoke();
            UIManager.Instance.JoystickScreen(false);
            UIManager.Instance.SettingsScreen(false);
            UIManager.Instance.PointerScreen(false);
            UIManager.Instance.LeaderboardScreen(false);
        }

        private void NewLevel()
        {
            LoadSave();
            if (isEditor)
                return;

            levelSpawner.SpawnLevel(lvlIndex);
            textLvlNumber.text = "LEVEL " + lvlNumber;
        }

        public void NextLevel()
        {
            lvlIndex++;
            lvlNumber++;
            if(lvlIndex >= 15)
            {
                lvlIndex = 0;
            }
            Save();
        }

        private IEnumerator IE_WinUI()
        {
            yield return new WaitForSeconds(5f);

            UIManager.Instance.BonusScreen(true);
            MoneyWallet.Instance.MoneyPlus(100);
        }

        #region Load&Save

        private void LoadSave()
        {
            lvlIndex = ES3.Load("lvlIndex", lvlIndex);
            lvlNumber = ES3.Load("lvlNumber", lvlNumber);
        }

        private void Save()
        {
            ES3.Save("lvlIndex", lvlIndex);
            ES3.Save("lvlNumber", lvlNumber);
        }

        #endregion
    }
}
