using System.Collections;
using UnityEngine;
using DG.Tweening;

namespace PlayKing.Cor
{
    public class PlayerFight : MonoBehaviour
    {
        [SerializeField] CharacterStates _characterStates;
        [SerializeField] CharacterMonster _characterMonster;
        [SerializeField] Weapon[] weapon;
        [SerializeField] ParticleSystem effects;
        private bool canAttack;
        private bool isAttack;

        private void Start()
        {
            LevelController.Instance.OnLevelEnd.AddListener(Test);
        }

        private void Update()
        {
            FightControll();
        }

        private void FightControll()
        {
            if (!_characterStates.IsMonsterStage())
                return;

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

        private void Test()
        {
            StartCoroutine(IE_S());
        }

        private IEnumerator IE_S()
        {
            yield return new WaitForSeconds(0.5f);

            CameraController.Instance.FinishCam();
            foreach (var i in weapon)
            {
                i.gameObject.SetActive(false);
            }
            _characterMonster.AttackFieldActive(false);
            StartCoroutine(IE_Effects());
        }

        private IEnumerator IE_Effects()
        {
            yield return new WaitForSeconds(1f);

            _characterStates.Dance();
            effects.Play();
            transform.DORotate(new Vector3(0f, 180f, 0f), 0.3f);
        }
    }
}
