using UnityEngine;

namespace Cor
{
    public class ButtonManager : MonoBehaviour
    {
        [SerializeField] SceneLoader _sceneLoader;
        [SerializeField] AdsTimer _adsTimer;

        public void Continue()
        {
            UIManager.Instance.MoneyScreen(true);
            UIManager.Instance.RewardScreen(true);
            UIManager.Instance.BonusScreen(false);
        }

        public void BonusMoney()
        {
            VibrationManager.Instance.AttackVibration();
        }

        public void SkipLevel()
        {
            AdsManager.Instance.SkipReward();
            VibrationManager.Instance.AttackVibration();
        }
    }
}
