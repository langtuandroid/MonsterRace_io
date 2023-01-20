using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace PlayKing.Cor
{
    public class LoadGame : MonoBehaviour
    {
        [SerializeField] Slider progressSlider;

        private void Start()
        {
            LoadScene(0);
        }

        public void LoadScene(int index)
        {
            StartCoroutine(LoadScene_Coroutine(index));
        }

        public IEnumerator LoadScene_Coroutine(int index)
        {
            progressSlider.value = 0;

            AsyncOperation asyncOperation = SceneManager.LoadSceneAsync(1);
            asyncOperation.allowSceneActivation = false;
            float progress = 0;

            while (!asyncOperation.isDone)
            {
                progress = Mathf.MoveTowards(progress, asyncOperation.progress, Time.deltaTime);
                progressSlider.value = progress;
                if (progress >= 0.9f)
                {
                    progressSlider.value = 1;
                    asyncOperation.allowSceneActivation = true;
                }
                yield return null;
            }
        }
    }
}
