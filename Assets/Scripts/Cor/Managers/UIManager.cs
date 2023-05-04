using UnityEngine;

namespace Cor
{
    public class UIManager : MonoBehaviour
    {
        #region Singelton

        public static UIManager Instance;

        private void Awake()
        {
            Instance = this;
        }

        #endregion

        [Header("Screens")]
        [SerializeField] GameObject joystickScreen;
        [SerializeField] GameObject tutorialScreen;
        [SerializeField] GameObject startScreen;
        [SerializeField] GameObject settingsButtonScreen;
        [SerializeField] GameObject settingsScreen;
        [SerializeField] GameObject moneyScreen;
        [SerializeField] GameObject pointerScreen;
        [SerializeField] GameObject leaderboardScreen;
        [SerializeField] GameObject bonusScreen;
        [SerializeField] GameObject rewardScreen;
        [SerializeField] GameObject loseScreen;

        public void JoystickScreen(bool isActive)
        {
            joystickScreen.SetActive(isActive);   
        }

        public void TutorialScreen(bool isActive)
        {
            tutorialScreen.SetActive(isActive);
        }

        public void StartScreen(bool isActive)
        {
            startScreen.SetActive(isActive);   
        }

        public void SettingsButtonScreen(bool isActive)
        {
            settingsButtonScreen.SetActive(isActive);
        }

        public void SettingsScreen(bool isActive)
        {
            settingsScreen.SetActive(isActive);
        }

        public void MoneyScreen(bool isActive)
        {
            moneyScreen.SetActive(isActive);
        }

        public void PointerScreen(bool isActive)
        {
            pointerScreen.SetActive(isActive);
        }

        public void LeaderboardScreen(bool isActive)
        {
            leaderboardScreen.SetActive(isActive);   
        }

        public void BonusScreen(bool isActive)
        {
            bonusScreen.SetActive(isActive);
        }

        public void RewardScreen(bool isActive)
        {
            rewardScreen.SetActive(isActive);
        }

        public void LoseScreen(bool isActive)
        {
            loseScreen.SetActive(isActive);   
        }
    }
}
