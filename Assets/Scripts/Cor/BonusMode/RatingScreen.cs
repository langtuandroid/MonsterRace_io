using UnityEngine;
using DG.Tweening;

namespace Cor
{
    public class RatingScreen : MonoBehaviour
    {
        #region Variables

        [SerializeField] GameObject buttonPlay;

        #endregion

        public void ActiveScreen()
        {
            buttonPlay.SetActive(true);
            buttonPlay.transform.DOPunchScale(new Vector3(0.1f, 0.1f, 0.1f), 1f, 1).SetEase(Ease.Linear).SetLoops(-1);
        }

        public void DeactiveScreen()
        {
            LevelManager.Instance.LevelStart();
            LevelManager.Instance.LevelFight();
            gameObject.SetActive(false);
        }
    }
}
