using UnityEngine;
using DG.Tweening;

namespace Core
{
    public class RingField : MonoBehaviour
    {
        #region Variables

        [SerializeField] private Vector3 scale;
        [SerializeField] private float speedScale;

        #endregion

        private void Start()
        {
            LevelManager.Instance.OnLevelStart += StartScale;
        }

        private void StartScale()
        {
            transform.DOScale(scale, speedScale).SetEase(Ease.Linear);
        }

        private void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("Character"))
            {
                other.GetComponentInParent<CharacterBonus>().Push();
            }
        }
    }
}
