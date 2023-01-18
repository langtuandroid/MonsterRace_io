using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace PlayKing.Cor
{
    public class LoadGame : MonoBehaviour
    {
        private void Start()
        {
            StartCoroutine(Load());    
        }

        private IEnumerator Load()
        {
            yield return new WaitForSeconds(0.2f);

            SceneManager.LoadScene(1);
        }
    }
}
