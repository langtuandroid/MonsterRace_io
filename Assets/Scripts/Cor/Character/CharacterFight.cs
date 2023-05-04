using System;
using UnityEngine;
using DG.Tweening;

namespace Cor
{
    public class CharacterFight : MonoBehaviour
    {
        #region Variables

        [SerializeField] GameObject attackField;
        [SerializeField] Weapon weapon;

        #endregion

        #region Actions

        public Action OnStartAttack;
        public Action OnEndAttack;

        #endregion

        private void OnEnable()
        {
            LevelManager.Instance.OnLevelFight += ActiveFight;
            LevelManager.Instance.OnLevelEnd += DeactiveFight;
        }

        private void OnDisable()
        {
            LevelManager.Instance.OnLevelFight -= ActiveFight;
            LevelManager.Instance.OnLevelEnd -= DeactiveFight;
        }

        public void SetWeapon(Weapon monsterWeapon) => weapon = monsterWeapon;

        public void Attack() => OnStartAttack?.Invoke();

        public void ReturnAttack() => OnEndAttack?.Invoke();

        private void ActiveFight()
        {
           // attackField.SetActive(true);
           // attackField.transform.DOScale(attackField.transform.localScale, 0.5f).From(0);
        }

        private void DeactiveFight()
        {
            attackField.transform.DOScale(0, 0.5f).OnComplete(() => attackField.SetActive(false));
            DOVirtual.DelayedCall(0.5f, () => weapon.gameObject.SetActive(false));
        }
    }
}
