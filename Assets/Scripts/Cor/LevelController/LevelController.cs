using System.Collections;
using UnityEngine;
using UnityEngine.Events;
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
        [SerializeField] MemberSpawner memberSpawner;
        [SerializeField] CollectableBallsField collectableBallsField;
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
            UIManager.Instance.PointerScreen(true);
            UIManager.Instance.LeaderboardScreen(true);
        }

        public void LevelCompleted()
        {
            LevelEnd();
            OnLevelCompleted?.Invoke();
            analyticsController.LevelFinished(true, lvlNumber);
            CameraController.Instance.ChangeMonsterCam(false);
            CameraController.Instance.JumpStateCam(true);
        }

        public void LevelFailed()
        {
            LevelEnd();
            analyticsController.LevelFinished(false, lvlNumber);
            UIManager.Instance.MoneyScreen(false);
            UIManager.Instance.LoseScreen(true);
        }

        private void LevelEnd()
        {
            OnLevelEnd.Invoke();
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
            memberSpawner.CreatePlayer(newArena.GetPlayerPoint());
            //memberSpawner.CreateBots(newArena.GetPoints(), newArena.GetMonsterPoints());
            collectableBallsField.SetPlacementSettings(newArena);
        }

        public void NextLevel()
        {
            lvlIndex++;
            lvlNumber++;
            if(lvlNumber >= 13) { lvlIndex = Random.Range(0, 11); }
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
