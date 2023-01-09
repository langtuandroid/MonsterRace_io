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

        private void SceneLoader(int indexScene)
        {
            SceneManager.LoadScene(indexScene);
        }
    }
}
