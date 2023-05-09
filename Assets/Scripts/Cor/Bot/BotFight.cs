using UnityEngine;

namespace Cor
{
    public class BotFight : MonoBehaviour
    {
        #region Variables

        [SerializeField] CharacterFight characterFight;
        [SerializeField] CharacterAnimation _characterStatesAnimation;
        public bool isAttack;

        #endregion

        private void Start()
        {
            LevelManager.Instance.OnLevelEnd += StopFight;
            characterFight.OnEndAttack += ReturnFight;
        }

        public void StopFight() => isAttack = true;

        private void ReturnFight() => isAttack = false;

        private void OnTriggerEnter(Collider other)
        {
            if (other.gameObject.tag == "Character")
            {
                if (isAttack)
                    return;

                characterFight.Attack();
                isAttack = true;
            }

            if (other.gameObject.tag == "Monster")
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

