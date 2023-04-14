using UnityEngine;

namespace Cor
{
    public class ButtonManager : MonoBehaviour
    {
        [SerializeField] SceneLoader _sceneLoader;

        public void Continue()
        {
            UIManager.Instance.MoneyScreen(true);
            UIManager.Instance.RewardScreen(true);
            UIManager.Instance.BonusScreen(false);
        }

        public void RestartLevel()
        {
            MoneyWallet.Instance.MoneyPlus(50);
            _sceneLoader.Loaded(0);
        }

        public void NextLevel()
        {
            MoneyWallet.Instance.MoneyPlus(100);
            _sceneLoader.Loaded(0);
        }
    }
}
