using UnityEngine;
using DG.Tweening;

namespace PlayKing.Cor
{
    public class Weapon : MonoBehaviour
    {
        [SerializeField] Collider _collider;
        [SerializeField] DOTweenAnimation punchAnim;
        [SerializeField] ParticleSystem dust;

        public void Attack()
        {
            _collider.enabled = true;
        }

        public void StopAttack()
        {
            _collider.enabled = false;
        }

        private void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("Platform"))
            {
                punchAnim.DORestart();
                dust.Play();
                Debug.Log("P");
            }

            if (other.CompareTag("Character"))
            {
                Character character = other.GetComponent<Character>();
                character.KillCharacter();
                VibrationController.Instance.AttackVibration();
            }

            if (other.CompareTag("Monster"))
            {
                CharacterMonster characterMonster = other.GetComponent<CharacterMonster>();
                if (characterMonster == GetComponentInParent<CharacterMonster>())
                    return;

                characterMonster.ExplosionCharacterMonster(transform);
                VibrationController.Instance.AttackVibration();
            }
        }
    }
}
