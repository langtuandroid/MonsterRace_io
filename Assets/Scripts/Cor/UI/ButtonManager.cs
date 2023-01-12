using UnityEngine;
using UnityEngine.SceneManagement;

namespace PlayKing.Cor
{
    public class ButtonManager : MonoBehaviour
    {
        public void StartLevel()
        {
            LevelController.Instance.LevelStart();
        }

        public void RestartLevel()
        {
            SceneLoader(0);
        }

        public void NextLevel()
        {
            SceneLoader(0);
        }

        private void SceneLoader(int indexScene)
        {
            SceneManager.LoadScene(indexScene);
        }
    }
}
