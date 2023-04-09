using System.Collections;
using UnityEngine;

namespace Cor
{
    public class BotFight : MonoBehaviour
    {
        #region Variables

        [SerializeField] CharacterStates _characterStates;
        [SerializeField] CharacterStatesAnimation _characterStatesAnimation;
        [SerializeField] CharacterMonster _characterMonster;
        [SerializeField] Weapon weapon;
        [SerializeField] BotMovement botMovement;
        public bool isAttack;

        #endregion

        private void Start()
        {
            LevelManager.Instance.OnLevelEnd.AddListener(StopFight);
            if(weapon == null)
            {
                SetWeapon(GetComponentInChildren<Weapon>());
            }
        }

        public void SetWeapon(Weapon monsterWeapon)
        {
            weapon = monsterWeapon;
        }

        private void StopFight()
        {
            _characterStatesAnimation.RunAnimation(false);

            //weapon.gameObject.SetActive(false);

            _characterMonster.AttackFieldActive(false);
        }

        private IEnumerator IE_Kick()
        {
            yield return new WaitForSeconds(0.2f);

            weapon.Attack();
        }

        private IEnumerator IE_ReturnAttack()
        {
            yield return new WaitForSeconds(0.7f);

            weapon.StopAttack();

            botMovement.MonsterReturnMove();
            isAttack = false;
        }

        private void OnTriggerEnter(Collider other)
        {
            if (other.gameObject.tag == "Character")
            {
                if (isAttack)
                    return;

                _characterStates.Attack();
                botMovement.Stop();
                StartCoroutine(IE_Kick());
                StartCoroutine(IE_ReturnAttack());
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

                _characterStates.Attack();
                botMovement.Stop();
                StartCoroutine(IE_Kick());
                StartCoroutine(IE_ReturnAttack());
                isAttack = true;
            }
        }
    }
}

