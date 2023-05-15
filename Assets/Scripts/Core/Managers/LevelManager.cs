using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using DG.Tweening;
using Core.SDK;
using Core.MyPool;
using Random = UnityEngine.Random;

namespace Core
{
    public class LevelManager : MonoBehaviour
    {
        #region Singelton

        public static LevelManager Instance;

        private void Awake()
        {
            Instance = this;
            InitNewLevel();
        }

        #endregion

        #region Variables
        
        [Header("GameMode")]
        [SerializeField] private GameModeType gameMode;

        [Space]
        [Header("Analytics")]
        [SerializeField] private AppMetricaAnalytics analytics;

        [Space]
        [Header("Spawners")]
        [SerializeField] private LevelSpawner levelSpawner;
        [SerializeField] private MemberSpawner memberSpawner;
        [SerializeField] private GatesSpawner gatesSpawner;
        [SerializeField] private CollectableBallsField collectableBallsField;
        [SerializeField] private NightPoolEntry nightPoolEntry;
        [SerializeField] private SkinsController skinsController;
        [SerializeField] private SceneLoader sceneLoader;
        [SerializeField] private LevelRewards levelRewards;
        
        [Space]
        [Header("LevelNumber")]
        [SerializeField] private int lvlNumber;

        private int _lvlIndex;
        private int _bonusLvlIndex;
        private bool _isLevelEnd;

        #endregion

        #region Actions

        public Action OnLevelStart;
        public Action OnLevelFight;
        public Action OnLevelPause;
        public Action OnLevelContinue;
        public Action OnLevelReload;
        public Action OnLevelEnd;
        public Action OnLevelCompleted;

        #endregion

        #region GetVariables

        public GameModeType GetGameMode()
        {
            return gameMode;
        }
        
        public int GetLvlNumber()
        {
            return lvlNumber;
        }

        #endregion
        
        private void Start()
        {
            Application.targetFrameRate = 60;
            if (gameMode != GameModeType.Game)
                return;
            DOVirtual.DelayedCall(0.2f, () => LevelStart());
        }

        public void LevelStart()
        {
            OnLevelStart?.Invoke();
            analytics.LoadData();
            analytics.NewAttempt();
            analytics.LevelStartEvent();
            UIManager.Instance.GameScreen(true);
        }

        public void LevelCompleted()
        {
            LevelEnd();
            OnLevelCompleted?.Invoke();
            if (gameMode == GameModeType.Game)
            {
                analytics.LevelFinishEvent("win");
                skinsController.OpenPart();
            }
            CameraController.Instance.ChangeMonsterCam(false);
            CameraController.Instance.JumpStateCam(true);
            NextLevel();
        }

        public void LevelFailed()
        {
            LevelEnd();
            if (gameMode == GameModeType.Game)
            {
                analytics.LevelFinishEvent("lose");
            }
            UIManager.Instance.MoneyScreen(true);
            UIManager.Instance.LoseScreen(true);
        }
        
        public void LevelFight() => OnLevelFight?.Invoke();

        public void LevelPause() => OnLevelPause?.Invoke();

        public void LevelContinue() => OnLevelContinue?.Invoke(); 

        public void SkipLevel()
        {
            NextLevel();
            skinsController.BonusPart();
            sceneLoader.Loaded(0);
        }

        public void ExitLevel(int index)
        {
            OnLevelReload?.Invoke();
            sceneLoader.Loaded((index));
        }
        
        private void InitNewLevel()
        {
            LoadSave();

            if (gameMode == GameModeType.Lobby)
                return;
            
            var lvlCreate = 0;
            if (lvlNumber >= 13) { _lvlIndex = Random.Range(0, 11); }

            lvlCreate = gameMode switch
            {
                GameModeType.Game => _lvlIndex,
                GameModeType.Bonus => _bonusLvlIndex,
                _ => lvlCreate
            };

            levelSpawner.SpawnLevel(lvlCreate);
            var newArena = levelSpawner.LevelArena();
            memberSpawner.CreatePlayer(newArena);
            memberSpawner.CreateBots(newArena);

            if (gameMode == GameModeType.Bonus)
                return;

            gatesSpawner.SetupGatesPoints(newArena);
            collectableBallsField.SetPlacementSettings(newArena);
            nightPoolEntry.SetupPool(newArena.GetPreset());
        }
        
        private void LevelEnd()
        {
            if (_isLevelEnd)
                return;

            OnLevelEnd.Invoke();
            _isLevelEnd = true;
            UIManager.Instance.GameScreen(false);
            if (gameMode == GameModeType.Bonus) 
                RatingLeaderboard.IsCompletedFight = true;
        }
        
        private void NextLevel()
        {
            switch (gameMode)
            {
                case GameModeType.Game:
                    _lvlIndex++;
                    lvlNumber++;
                    if (lvlNumber >= 22)
                    {
                        _lvlIndex = Random.Range(0, 20);
                    }
                    analytics.LevelLoop();
                    analytics.NewLevel();
                    levelRewards.UpdateReward();
                    break;
                case GameModeType.Bonus:
                    _bonusLvlIndex++;
                    if (_bonusLvlIndex == 4)
                        _bonusLvlIndex = 1;
                    break;
            }
            Save();
        }
        
        #region Load&Save

        private void LoadSave()
        {
            _lvlIndex = ES3.Load("lvlIndex", _lvlIndex);
            lvlNumber = ES3.Load("lvlNumber", lvlNumber);
            _bonusLvlIndex = ES3.Load("bonusLvlIndex", _bonusLvlIndex);
        }

        private void Save()
        {
            ES3.Save("lvlIndex", _lvlIndex);
            ES3.Save("lvlNumber", lvlNumber);
            ES3.Save("bonusLvlIndex", _bonusLvlIndex);
        }

        #endregion
        
        //Test arenas
        public void SetLevelNumber(int indexLvl)
        {
            _lvlIndex = indexLvl;
            Save();
            SceneManager.LoadScene(1);
        }
    }
}
