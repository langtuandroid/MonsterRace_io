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
        [SerializeField] GameObject tutorialScreen;
        [SerializeField] GameObject moneyScreen;
        [SerializeField] GameObject gameScreen;
        [SerializeField] GameObject bonusScreen;
        [SerializeField] GameObject rewardScreen;
        [SerializeField] GameObject loseScreen;

        public void TutorialScreen(bool isActive) => tutorialScreen.SetActive(isActive);

        public void MoneyScreen(bool isActive) => moneyScreen.SetActive(isActive);

        public void GameScreen(bool isActive) => gameScreen.SetActive(true);

        public void BonusScreen(bool isActive) => bonusScreen.SetActive(isActive);

        public void RewardScreen(bool isActive) => rewardScreen.SetActive(isActive);

        public void LoseScreen(bool isActive) => loseScreen.SetActive(isActive);
    }
}
