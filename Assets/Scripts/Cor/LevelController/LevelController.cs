using System.Collections;
using UnityEngine;
using UnityEngine.Events;

namespace PlayKing.Cor
{
    public class LevelController : MonoBehaviour
    {
        #region Singelton

        public static LevelController Instance;

        private void Awake()
        {
            Instance = this;
        }

        #endregion

        [HideInInspector]
        public UnityEvent OnLevelStart;
        [HideInInspector]
        public UnityEvent OnLevelEnd;

        public void LevelStart()
        {
            OnLevelStart.Invoke();
            UIManager.Instance.TutorialScreen(false);   
            UIManager.Instance.StartScreen(false);
            UIManager.Instance.MoneyScreen(false);
            UIManager.Instance.PointerScreen(true);
            UIManager.Instance.LeaderboardScreen(true);
        }

        public void LevelCompleted()
        {
            LevelEnd();
            StartCoroutine(IE_WinUI());
        }

        public void LevelFailed()
        {
            LevelEnd();
            UIManager.Instance.LoseScreen(true);
        }

        private void LevelEnd()
        {
            OnLevelEnd.Invoke();
            UIManager.Instance.SettingsScreen(false);
            UIManager.Instance.PointerScreen(false);
            UIManager.Instance.LeaderboardScreen(false);
        }

        private IEnumerator IE_WinUI()
        {
            yield return new WaitForSeconds(5f);

            UIManager.Instance.MoneyScreen(true);
            UIManager.Instance.WinScreen(true);
            MoneyWallet.Instance.MoneyPlus(100);
        }
    }
}
