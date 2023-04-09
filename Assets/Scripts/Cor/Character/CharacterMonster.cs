using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

namespace Cor
{
    public class CharacterMonster : MonoBehaviour
    {
        [System.Serializable]
        public class Monster
        {
            public CharacterMonsterType monsterType;
            public RuntimeAnimatorController monsterAnimator;
        }

        #region Variables

        [SerializeField] List<Monster> monsters = new List<Monster>();
        [SerializeField] Transform monsterPoint;
        [SerializeField] CharacterStates _characterStates;
        [SerializeField] CharacterSkins _characterSkins;
        [SerializeField] CharacterStatesAnimation characterStatesAnimation;
        [SerializeField] MonsterSpine _monsterSpine;
        [SerializeField] GameObject attackField;
        [SerializeField] Animator _anim;

        #endregion

        public Transform MonsterPoint()
        {
            return monsterPoint;
        }

        public void SetMonsterAnimator(CharacterMonsterType _monsterType)
        {
            _anim = GetComponentInChildren<Animator>();
            foreach (var i in monsters)
            {
                if (i.monsterType == _monsterType)
                {
                    _anim.runtimeAnimatorController = i.monsterAnimator;
                    characterStatesAnimation.AddMonsterAnimator(_anim);
                    break;
                }
            }
        }

        public void ExplosionCharacterMonster(Transform target)
        {
            _characterStates.CharacterDie();
            _characterStates.Die();
            _monsterSpine.CrushSpine(target);
        }

        public void AttackFieldActive(bool isActive)
        {
            if (isActive) { attackField.transform.DOScale(attackField.transform.localScale, 0.5f).From(0); }
            if (!isActive) { attackField.transform.DOScale(0, 0.5f); }
        }
    }
}
