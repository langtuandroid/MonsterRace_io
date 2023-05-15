using UnityEngine;

namespace Core
{
    public class BotFight : MonoBehaviour
    {
        #region Variables

        [SerializeField] private CharacterFight characterFight;
        public bool isAttack;
        private bool _isLockFight;

        #endregion

        private void Start()
        {
            LevelManager.Instance.OnLevelEnd += StopFight;
            characterFight.OnEndAttack += ReturnFight;
        }

        public void StopFight() => _isLockFight = true;

        private void ReturnFight() => isAttack = false;

        private void OnTriggerEnter(Collider other)
        {
            if (_isLockFight)
                return;
                
            if (other.CompareTag("Character"))
            {
                if (isAttack)
                    return;

                characterFight.Attack();
                isAttack = true;
            }

            if (other.CompareTag("Monster"))
            {
                if (other.gameObject.GetComponentInParent<CharacterStates>().IsPlayerCharacter())
                    return;

                if (other.gameObject.GetComponent<BotFight>() != null)
                {
                    if (other.gameObject.GetComponent<BotFight>().isAttack)
                        return;
                }

                if (isAttack)
                    return;

                characterFight.Attack();
                isAttack = true;
            }
        }

        private void OnDestroy()
        {
            LevelManager.Instance.OnLevelEnd -= StopFight;
        }
    }
}

