using UnityEngine;
using DG.Tweening;

namespace BlueStellar.Cor
{
    public class Weapon : MonoBehaviour
    {
        [SerializeField] Collider _collider;
        [SerializeField] DOTweenAnimation punchAnim;
        [SerializeField] ParticleSystem dust;
        CharacterStates characterStates;

        private void Start()
        {
            characterStates = GetComponentInParent<CharacterStates>();    
        }

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
            if (other.gameObject.tag == "Platform")
            {
                punchAnim.DORestart();
                dust.Play();
            }

            if (other.gameObject.tag == "Character")
            {
                Character character = other.GetComponent<Character>();
                character.KillCharacter();

                if(characterStates.IsPlayerCharacter())
                    VibrationController.Instance.AttackVibration();
            }

            if (other.gameObject.tag == "Monster")
            {
                CharacterMonster characterMonster = other.GetComponent<CharacterMonster>();
                if (characterMonster == GetComponentInParent<CharacterMonster>())
                    return;

                characterMonster.ExplosionCharacterMonster(transform);

                if (characterStates.IsPlayerCharacter())
                    VibrationController.Instance.AttackVibration();
            }
        }
    }
}
