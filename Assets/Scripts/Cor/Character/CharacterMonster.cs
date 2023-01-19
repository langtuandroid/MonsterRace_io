using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public enum CharacterMonsterType
{
    HuggyWuggy,
    Baldy,
    MotherSpider,
    CartoonCat,
    Siren,
    Venom
}

namespace PlayKing.Cor
{
    public class CharacterMonster : MonoBehaviour
    {
        [System.Serializable]
        public class Monster
        {
            public CharacterMonsterType monsterType;
            public List<GameObject> monsterBody;
            public GameObject monsterWeapon;
            public RuntimeAnimatorController monsterAnimator;
        }

        [SerializeField] List<Monster> monsters = new List<Monster>();
        [SerializeField] List<GameObject> monsterHeads = new List<GameObject>();
        [SerializeField] CharacterStates _characterStates;
        [SerializeField] CharacterSkins _characterSkins;
        [SerializeField] MonsterSpine _monsterSpine;
        [SerializeField] GameObject attackField;
        [SerializeField] Animator _anim;

        public void SetMonster(CharacterMonsterType _monsterType)
        {
            foreach(var i in monsters)
            {
                if(i.monsterType == _monsterType)
                {
                    foreach(var d in i.monsterBody) { d.SetActive(true); }
                    i.monsterWeapon.SetActive(true);
                    _anim.runtimeAnimatorController = i.monsterAnimator;
                    break;
                }
            }

            SwitchHead(_characterSkins.Type());
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

        private void SwitchHead(CharacterMonsterType characterMonster)
        {
            switch (characterMonster)
            {
                case CharacterMonsterType.HuggyWuggy:
                    monsterHeads[0].SetActive(true);
                    break;
                case CharacterMonsterType.MotherSpider:
                    monsterHeads[1].SetActive(true);
                    break;
                case CharacterMonsterType.Baldy:
                    monsterHeads[2].SetActive(true);
                    break;
                case CharacterMonsterType.CartoonCat:
                    monsterHeads[3].SetActive(true);
                    break;
                case CharacterMonsterType.Siren:
                    monsterHeads[4].SetActive(true);
                    break;
                case CharacterMonsterType.Venom:
                    monsterHeads[5].SetActive(true);
                    break;
            }
        }
    }
}
