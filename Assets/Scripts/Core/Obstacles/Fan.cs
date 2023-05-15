using UnityEngine;
using DG.Tweening;

namespace Core
{
    public class Fan : MonoBehaviour
    {
        #region Variables

        [SerializeField] Transform propeller;

        CharacterStates _characterStates;

        #endregion

        private void Start()
        {
            propeller.DORotate(new Vector3(0f, 359f, 0f), 1.2f, RotateMode.WorldAxisAdd).
                SetEase(Ease.Linear).SetLoops(-1);
        }

        private void OnTriggerStay(Collider other)
        {
            if (other.CompareTag("Character") || other.CompareTag("Monster"))
            {
                _characterStates = other.GetComponentInParent<CharacterStates>();
                _characterStates.SetFlying(true);
            }
        }

        private void OnTriggerExit(Collider other)
        {
            if (other.CompareTag("Character") || other.CompareTag("Monster"))
            {
                other.GetComponentInParent<CharacterStates>().SetFlying(false);
            }
        }
    }
}
