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
            LevelManager.Instance.OnLevelCompleted += DeactiveWeapon;
        }

        public void Attack() => DOVirtual.DelayedCall(0.5f, () => _collider.enabled = true);

        public void StopAttack()
        {
            DOVirtual.DelayedCall(0.1f, () => _collider.enabled = false);
            DOVirtual.DelayedCall(0.1f, () => _characterFight.ReturnAttack());
        }

        private void DeactiveWeapon()
        {
            transform.DOScale(0, 0.3f).OnComplete(() => Destroy(gameObject));
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
                if (character == GetComponentInParent<Character>())
                    return;
                if (GetComponentInParent<CharacterBonus>() != null)
                {
                    CharacterBonus characterBonus = GetComponentInParent<CharacterBonus>();
                    float scale = character.transform.localScale.x / 2;
                    characterBonus.Upgrade(scale);
                }
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

        private void OnDestroy()
        {
            LevelManager.Instance.OnLevelCompleted -= DeactiveWeapon;
        }
    }
}
