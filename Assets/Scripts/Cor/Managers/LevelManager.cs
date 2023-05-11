using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using DG.Tweening;
using Cor.SDK;
using Cor.MyPool;
using Random = UnityEngine.Random;

namespace Cor
{
    public class LevelManager : MonoBehaviour
    {
        #region Singelton

        public static LevelManager Instance;

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
        [SerializeField] SkinsController skinsController;
        [SerializeField] SceneLoader sceneLoader;
        [SerializeField] LevelRewards levelRewards;
        [SerializeField] NightPoolEntry nightPoolEntry;
        [SerializeField] private int lvlNumber;
        [SerializeField] GameModeType _gameMode;

        private int lvlIndex;
        private int bonusLvlIndex;
        private bool isLevelEnd;

        #endregion

        #region Actions

        public Action OnLevelStart;
        public Action OnLevelFight;
        public Action OnLevelPause;
        public Action OnLevelContinue;
        public Action OnLevelEnd;
        public Action OnLevelCompleted;

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
            Application.targetFrameRate = 60;
            if (_gameMode == GameModeType.Bonus)
                return;
            DOVirtual.DelayedCall(0.2f, () => LevelStart());
        }

        public void LevelStart()
        {
            OnLevelStart?.Invoke();
            _analytics.LoadData();
            _analytics.NewAttempt();
            _analytics.LevelStartEvent();
            UIManager.Instance.GameScreen(true);
        }

        public void LevelCompleted()
        {
            LevelEnd();
            OnLevelCompleted?.Invoke();
            if (_gameMode == GameModeType.Game)
            {
                _analytics.LevelFinishEvent("win");
                skinsController.OpenPart();
            }
            CameraController.Instance.ChangeMonsterCam(false);
            CameraController.Instance.JumpStateCam(true);
            NextLevel();
        }

        public void LevelFailed()
        {
            LevelEnd();
            if (_gameMode == GameModeType.Game)
            {
                _analytics.LevelFinishEvent("lose");
            }
            UIManager.Instance.MoneyScreen(true);
            UIManager.Instance.LoseScreen(true);
        }

        private void LevelEnd()
        {
            if (isLevelEnd)
                return;

            OnLevelEnd.Invoke();
            isLevelEnd = true;
            UIManager.Instance.GameScreen(false);
            if (_gameMode == GameModeType.Bonus) 
                RatingLeaderboard.isCompletedFight = true;
        }

        private void NewLevel()
        {
            LoadSave();

            int lvlCreate = 0;
            if (lvlNumber >= 13) { lvlIndex = Random.Range(0, 11); }

            if (_gameMode == GameModeType.Game) lvlCreate = lvlIndex;
            if (_gameMode == GameModeType.Bonus) lvlCreate = bonusLvlIndex;

            levelSpawner.SpawnLevel(lvlCreate);
            Arena newArena = levelSpawner.LevelArena();
            memberSpawner.CreatePlayer(newArena);
            memberSpawner.CreateBots(newArena);

            if (_gameMode == GameModeType.Bonus)
                return;

            gatesSpawner.SetupGatesPoints(newArena);
            collectableBallsField.SetPlacementSettings(newArena);
            nightPoolEntry.SetupPool(newArena.GetPreset());
        }

        private void NextLevel()
        {
            switch (_gameMode)
            {
                case GameModeType.Game:
                    lvlIndex++;
                    lvlNumber++;
                    if (lvlNumber >= 22)
                    {
                        lvlIndex = Random.Range(0, 20);
                    }
                    _analytics.LevelLoop();
                    _analytics.NewLevel();
                    levelRewards.UpdateReward();
                    break;
                case GameModeType.Bonus:
                    bonusLvlIndex++;
                    if (bonusLvlIndex == 4)
                        bonusLvlIndex = 1;
                    break;
            }
            Save();
        }

        public void SetLevelNumber(int indexLvl)
        {
            lvlIndex = indexLvl;
            Save();
            SceneManager.LoadScene(1);
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

        public void ReloadBonusMode()
        {
            sceneLoader.Loaded(2);
        }

        #region Load&Save

        private void LoadSave()
        {
            lvlIndex = ES3.Load("lvlIndex", lvlIndex);
            lvlNumber = ES3.Load("lvlNumber", lvlNumber);
            bonusLvlIndex = ES3.Load("bonusLvlIndex", bonusLvlIndex);
        }

        private void Save()
        {
            ES3.Save("lvlIndex", lvlIndex);
            ES3.Save("lvlNumber", lvlNumber);
            ES3.Save("bonusLvlIndex", bonusLvlIndex);
        }

        #endregion
    }
}
