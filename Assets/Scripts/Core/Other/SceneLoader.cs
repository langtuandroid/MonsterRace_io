using UnityEngine;
using UnityEngine.SceneManagement;
using DG.Tweening;

namespace Core
{
    public class SceneLoader : MonoBehaviour
    {
        #region Variables

        [SerializeField] Animator _loadAnim;

        #endregion

        public void Loaded(int indexScene)
        {
            _loadAnim.SetTrigger("EndLoad");
            DOVirtual.DelayedCall(1f, () => SceneManager.LoadScene(indexScene));
        }
    }
}
