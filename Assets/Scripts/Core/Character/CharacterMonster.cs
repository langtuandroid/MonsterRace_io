using System.Collections.Generic;
using UnityEngine;

namespace Core
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

        [SerializeField] private List<Monster> monsters = new List<Monster>();
        [SerializeField] private Transform monsterPoint;
        [SerializeField] private CharacterStates characterStates;
        [SerializeField] private CharacterAnimation characterStatesAnimation;
        [SerializeField] private MonsterSpine monsterSpine;
        [SerializeField] private Animator anim;

        #endregion

        public Transform MonsterPoint()
        {
            return monsterPoint;
        }

        public void SetMonsterAnimator(CharacterMonsterType _monsterType)
        {
            anim = GetComponentInChildren<Animator>();
            foreach (var i in monsters)
            {
                if (i.monsterType == _monsterType)
                {
                    anim.runtimeAnimatorController = i.monsterAnimator;
                    characterStatesAnimation.SetAnimator(anim);
                    break;
                }
            }
        }

        public void ExplosionCharacterMonster(Transform target)
        {
            characterStates.CharacterDie();
            characterStates.Die();
            monsterSpine.CrushSpine(target);
        }
    }
}
