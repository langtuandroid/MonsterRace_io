using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PlayKing.Cor
{
    public class BotFight : MonoBehaviour
    {
        [SerializeField] CharacterStates _characterStates;
        [SerializeField] CharacterMonster _characterMonster;
        [SerializeField] Weapon[] weapon;
        private bool canFight;
        private bool canAttack;
        private bool isAttack;

        private void Start()
        {
            LevelController.Instance.OnLevelStart.AddListener(Fight);
            LevelController.Instance.OnLevelEnd.AddListener(StopFight);
            LevelController.Instance.OnLevelEnd.AddListener(Test);
        }

        private void Fight()
        {
            canFight = true;
        }

        private void StopFight()
        {
            canFight = false;
        }

        private void Test()
        {
            StartCoroutine(IE_S());
        }

        private void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("Character"))
            {
                _characterStates.Attack();
                _characterStates.StopMovement(true);
                StartCoroutine(IE_Kick());
                StartCoroutine(IE_ReturnAttack());
                isAttack = true;
                canAttack = false;
            }

            if (other.gameObject.CompareTag("Monster"))
            {
                _characterStates.Attack();
                _characterStates.StopMovement(true);
                StartCoroutine(IE_Kick());
                StartCoroutine(IE_ReturnAttack());
                isAttack = true;
                canAttack = false;
            }
        }

        private IEnumerator IE_Kick()
        {
            yield return new WaitForSeconds(0.2f);

            foreach (var i in weapon)
            {
                i.Attack();
            }
        }

        private IEnumerator IE_ReturnAttack()
        {
            yield return new WaitForSeconds(0.7f);

            foreach (var i in weapon)
            {
                i.StopAttack();
            }

            isAttack = false;
            _characterStates.StopMovement(false);
        }

        private IEnumerator IE_S()
        {
            yield return new WaitForSeconds(0.5f);

            foreach (var i in weapon)
            {
                i.gameObject.SetActive(false);
            }

            _characterMonster.AttackFieldActive(false);
        }
    }
}

