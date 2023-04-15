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

        public void RestartLevel()
        {
            MoneyWallet.Instance.MoneyPlus(50);
            if (_adsTimer.IsReadyTimeAd) AdsManager.Instance.ShowInter();
            _sceneLoader.Loaded(0);
        }

        public void NextLevel()
        {
            MoneyWallet.Instance.MoneyPlus(100);
            if (_adsTimer.IsReadyTimeAd) AdsManager.Instance.ShowInter();
            _sceneLoader.Loaded(0);
        }
    }
}
