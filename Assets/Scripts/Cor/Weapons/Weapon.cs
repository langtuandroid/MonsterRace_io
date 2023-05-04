using UnityEngine;
using DG.Tweening;

namespace Cor
{
    public class Weapon : MonoBehaviour
    {
        #region Variables

        [SerializeField] Collider _collider;
        [SerializeField] DOTweenAnimation punchAnim;
        [SerializeField] ParticleSystem dust;

        private CharacterFight _characterFight;

        #endregion

        private void Start()
        {
            _characterFight = GetComponentInParent<CharacterFight>();
            _characterFight.OnStartAttack += Attack;
        }

        public void Attack() => DOVirtual.DelayedCall(0.5f, () => _collider.enabled = true);

        public void StopAttack()
        {
            DOVirtual.DelayedCall(0.1f, () => _collider.enabled = false);
            DOVirtual.DelayedCall(0.1f, () => _characterFight.ReturnAttack());
        }

        private void OnTriggerEnter(Collider other)
        {
            if (other.gameObject.tag == "Platform")
            {
                punchAnim.DORestart();
                dust.Play();
                StopAttack();
            }

            if (other.gameObject.tag == "Character")
            {
                Character character = other.GetComponent<Character>();
                character.KillCharacter();
            }

            if (other.gameObject.tag == "Monster")
            {
                CharacterMonster characterMonster = other.GetComponent<CharacterMonster>();
                if (characterMonster == GetComponentInParent<CharacterMonster>())
                    return;

                characterMonster.ExplosionCharacterMonster(transform);
            }
        }
    }
}
