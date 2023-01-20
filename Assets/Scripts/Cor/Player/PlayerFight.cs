using System.Collections;
using UnityEngine;

namespace PlayKing.Cor
{
    public class PlayerFight : MonoBehaviour
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

        private void Update()
        {
            if (!canFight || !_characterStates.IsMonsterStage())
                return;

            FightControll();
        }

        private void FightControll()
        {
            if (Input.GetMouseButton(0))
            {
                if (isAttack)
                    return;

                canAttack = true;
            }

            if (Input.GetMouseButtonUp(0))
            {
                if (!canAttack)
                    return;

                _characterStates.Attack();
                _characterStates.StopMovement(true);
                StartCoroutine(IE_Kick());
                StartCoroutine(IE_ReturnAttack());
                isAttack = true;
                canAttack = false;
            }
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
