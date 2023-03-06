using System.Collections;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

namespace BlueStellar.Cor
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

        #region Variables

        [SerializeField] AnalyticsController analyticsController;
        [SerializeField] LevelSpawner levelSpawner;
        //[SerializeField] LevelsProgress levelsProgress;
        //[SerializeField] Text textLvlNumber;
        [SerializeField] private int lvlNumber;
        [SerializeField] private bool isMain;
        [SerializeField] private bool isEditor;
        private int lvlIndex;

        #endregion

        #region LevelEvents

        [HideInInspector]
        public UnityEvent OnLevelStart;
        [HideInInspector]
        public UnityEvent OnLevelEnd;
        [HideInInspector]
        public UnityEvent OnLevelCompleted;

        #endregion

        public int LvlNumber()
        {
            return lvlNumber;
        }

        public int LvlIndex()
        {
            return lvlIndex;
        }

        private void Start()
        {
            if (isMain)
                return;

            StartCoroutine(IE_LevelStart());
        }

        public IEnumerator IE_LevelStart()
        {
            yield return new WaitForSeconds(0.15f);

            OnLevelStart.Invoke();
            analyticsController.LevelStart(lvlNumber);
            UIManager.Instance.TutorialScreen(false);   
            UIManager.Instance.PointerScreen(true);
            UIManager.Instance.LeaderboardScreen(true);
        }

        public void LevelCompleted()
        {
            LevelEnd();
            OnLevelCompleted?.Invoke();
            CameraController.Instance.ChangeMonsterCam(false);
            CameraController.Instance.JumpStateCam(true);
        }

        public void LevelFailed()
        {
            LevelEnd();
            UIManager.Instance.MoneyScreen(false);
            UIManager.Instance.LoseScreen(true);
        }

        private void LevelEnd()
        {
            OnLevelEnd.Invoke();
            analyticsController.LevelFinished(lvlNumber);
            UIManager.Instance.JoystickScreen(false);
            UIManager.Instance.SettingsButtonScreen(false);
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
            //levelsProgress.CheckLevelsProgress();
            //textLvlNumber.text = "Level " + lvlNumber;
        }

        public void NextLevel()
        {
            lvlIndex++;
            lvlNumber++;
            if(lvlIndex >= 15)
            {
                lvlIndex = 0;
            }
           // levelsProgress.ProgressUp();
            Save();
        }

        public void SetLevelNumber(int indexLvl)
        {
            lvlIndex = indexLvl;
            Save();
            SceneManager.LoadScene(2);
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
