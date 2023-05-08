using UnityEngine;
using DG.Tweening;

namespace Cor
{
    public class CharacterBonus : MonoBehaviour
    {
        #region Variables

        [SerializeField] Transform weaponPoint;
        [SerializeField] CharacterFight _characterFight;
        [SerializeField] CharacterAnimation _characterStatesAnimation;
        [SerializeField] PlayerMovement _playerMovement;
        [SerializeField] private float scale;
        private WeaponSpawner weaponSpawner;

        #endregion

        private void OnEnable()
        {
            _characterFight.OnStartAttack += Attack;
            _characterFight.OnEndAttack += Return;
        }

        private void OnDestroy()
        {
            _characterFight.OnStartAttack -= Attack;
            _characterFight.OnEndAttack -= Return;
        }

        public float GetScale()
        {
            return scale;
        }

        private void Start()
        {
            weaponSpawner = GameObject.FindObjectOfType<WeaponSpawner>();
            weaponSpawner.SpawnWeapon(weaponPoint, weaponSpawner.GetIndex());
        }

        private void Attack()
        {
            _characterStatesAnimation.AttackAnimation();
            StopMovement(true);
        }

        private void Return()
        {
            StopMovement(false);
        }

        public void StopMovement(bool isStop)
        {
            if (isStop)
            {
                _characterStatesAnimation.RunAnimation(false);

                if (_playerMovement != null)
                    _playerMovement.LockControll(true);

                return;
            }

            if (_playerMovement != null)
                _playerMovement.LockControll(false);
        }

        public void Upgrade(float number)
        {
            scale += number;
            transform.DOScale(scale, 0.3f);
        }

        public void DieCharacter()
        {

        }
    }
}
