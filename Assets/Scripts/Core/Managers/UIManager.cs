using UnityEngine;

namespace Core
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

        #region Variables

        [Header("Screens")]
        [SerializeField] private GameObject tutorialScreen;
        [SerializeField] private GameObject moneyScreen;
        [SerializeField] private GameObject gameScreen;
        [SerializeField] private GameObject bonusScreen;
        [SerializeField] private GameObject rewardScreen;
        [SerializeField] private GameObject loseScreen;

        #endregion

        public void TutorialScreen(bool isActive) => tutorialScreen.SetActive(isActive);

        public void MoneyScreen(bool isActive) => moneyScreen.SetActive(isActive);

        public void GameScreen(bool isActive) => gameScreen.SetActive(isActive);

        public void BonusScreen(bool isActive) => bonusScreen.SetActive(isActive);

        public void RewardScreen(bool isActive) => rewardScreen.SetActive(isActive);

        public void LoseScreen(bool isActive) => loseScreen.SetActive(isActive);
    }
}
