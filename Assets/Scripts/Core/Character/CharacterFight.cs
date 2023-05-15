using System;
using UnityEngine;
using DG.Tweening;

namespace Core
{
    public class CharacterFight : MonoBehaviour
    {
        #region Variables

        [SerializeField] private GameObject attackField;
        [SerializeField] private bool isAttack;

        #endregion

        #region Actions

        public Action OnStartAttack;
        public Action OnEndAttack;

        #endregion

        private void OnDestroy()
        {
            LevelManager.Instance.OnLevelFight -= ActiveFight;
            LevelManager.Instance.OnLevelEnd -= DeactiveFight;
        }

        private void Start()
        {
            LevelManager.Instance.OnLevelFight += ActiveFight;
            LevelManager.Instance.OnLevelEnd += DeactiveFight;
        }

        public void Attack()
        {
            if (isAttack)
                return;

            OnStartAttack?.Invoke();
            isAttack = true;
        }

        public void ReturnAttack()
        {
            OnEndAttack?.Invoke();
            isAttack = false;
        }

        private void ActiveFight()
        {
            attackField.SetActive(true);
            attackField.transform.DOScale(attackField.transform.localScale, 0.5f).From(0);
        }

        public void DeactiveFight()
        {
            attackField.transform.DOScale(0, 0.5f).OnComplete(() => attackField.SetActive(false));
        }
    }
}
