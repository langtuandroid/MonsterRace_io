using UnityEngine;
using DG.Tweening;

namespace Core
{
    public class KnockLet : MonoBehaviour
    {
        #region Variables

        [SerializeField] private float speedRotate;

        #endregion

        private void OnEnable()
        {
            LevelManager.Instance.OnLevelStart += ActivityLet;
        }

        private void OnDisable()
        {
            LevelManager.Instance.OnLevelStart -= ActivityLet;
        }

        private void ActivityLet()
        {
            transform.DORotate(new Vector3(0f, 359f, 0f), speedRotate, RotateMode.WorldAxisAdd).SetLoops(-1).SetEase(Ease.Linear);
        }

        private void OnTriggerEnter(Collider other)
        {
            if(other.CompareTag("Character"))
            {
                if(other.GetComponent<Character>() != null)
                    other.GetComponent<Character>().KnockCharacter(transform);
            }
        }
    }
}
