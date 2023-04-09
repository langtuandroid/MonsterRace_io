using System.Collections;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;
using Cor.SDK;

namespace Cor
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

        [SerializeField] AppMetricaAnalytics _analytics;
        [SerializeField] LevelSpawner levelSpawner;
        [SerializeField] MemberSpawner memberSpawner;
        [SerializeField] GatesSpawner gatesSpawner;
        [SerializeField] CollectableBallsField collectableBallsField;
        [SerializeField] private int lvlNumber;
        [SerializeField] private bool isMain;
        [SerializeField] private bool isEditor;
        private int lvlIndex;
        private bool isLevelEnd;

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

        public void LevelCompleted()
        {
            LevelEnd();
            OnLevelCompleted?.Invoke();
            _analytics.LevelFinishEvent("win");
            CameraController.Instance.ChangeMonsterCam(false);
            CameraController.Instance.JumpStateCam(true);
            NextLevel();
        }

        public void LevelFailed()
        {
            LevelEnd();
            _analytics.LevelFinishEvent("lose");
            UIManager.Instance.MoneyScreen(false);
            UIManager.Instance.LoseScreen(true);
        }

        private void LevelEnd()
        {
            if (isLevelEnd)
                return;

            OnLevelEnd.Invoke();
            isLevelEnd = true;
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

            if (lvlNumber >= 13) { lvlIndex = Random.Range(0, 11); }
            levelSpawner.SpawnLevel(lvlIndex);
            Arena newArena = levelSpawner.LevelArena();
            collectableBallsField.SetPlacementSettings(newArena);
            memberSpawner.CreatePlayer(newArena);
            memberSpawner.CreateBots(newArena);
            gatesSpawner.SetupGatesPoints(newArena);
        }

        public void NextLevel()
        {
            lvlIndex++;
            lvlNumber++;
            if(lvlNumber >= 13) 
            { 
                lvlIndex = Random.Range(0, 11);
            }

            _analytics.LevelLoop();
            _analytics.NewLevel();
            Save();
        }

        public void SetLevelNumber(int indexLvl)
        {
            lvlIndex = indexLvl;
            Save();
            SceneManager.LoadScene(1);
        }

        private IEnumerator IE_LevelStart()
        {
            yield return new WaitForSeconds(0.15f);

            OnLevelStart.Invoke();
            _analytics.LoadData();
            _analytics.NewAttempt();
            _analytics.LevelStartEvent();
            UIManager.Instance.PointerScreen(true);
            UIManager.Instance.LeaderboardScreen(true);
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
