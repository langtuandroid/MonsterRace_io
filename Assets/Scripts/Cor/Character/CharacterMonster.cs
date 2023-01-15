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
        [SerializeField] List<MonsterBall> currencyBalls = new List<MonsterBall>();
        [SerializeField] CharacterStates _characterStates;
        [SerializeField] CharacterSkins _characterSkins;
        [SerializeField] Animator _anim;
        [SerializeField] GameObject attackField;

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

        public void AddMonsterBall(MonsterBall monsterBall)
        {
            currencyBalls.Add(monsterBall);
        }

        public void ExplosionCharacterMonster(Transform target)
        {
            foreach (var i in currencyBalls)
            {
                Vector3 dirImpulse = target.position - i.transform.position;
                i.Explosion(dirImpulse);
                i.transform.parent = null;
            }

            _characterStates.CharacterDie();
            _characterStates.Die();
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

        public void AttackFieldActive(bool isActive)
        {
            if (isActive) { attackField.transform.DOScale(attackField.transform.localScale, 0.5f).From(0); }
            if (!isActive) { attackField.transform.DOScale(0, 0.5f); }
        }

        //public void Stopped()
        //{
        //    _characterStates.Stop();    
        //}

        //private void OnTriggerEnter(Collider other)
        //{
        //    if (other.gameObject.CompareTag("Character"))
        //    {
        //        if (isAttack)
        //            return;

        //        _characterStates.Attack();
        //        StartCoroutine(Kill(other.GetComponent<Character>()));
        //        isAttack = true;
        //    }

        //    if (other.gameObject.CompareTag("Monster"))
        //    {
        //        if (!isPlayer)
        //            return;

        //        if (isAttack)
        //            return;

        //        CharacterMonster monster = other.GetComponent<CharacterMonster>();

        //        _characterStates.Attack();
        //        monster.Stopped();
        //        monster.transform.LookAt(transform);
        //        StartCoroutine(IE_KillMonster(monster));
        //        isAttack = true;
        //    }
        //}

        //private IEnumerator Kill(Character character)
        //{
        //    yield return new WaitForSeconds(0.4f);

        //    character.KillCharacter(transform);
        //    isAttack = false;
        //}

        //private IEnumerator IE_KillMonster(CharacterMonster monster)
        //{
        //    yield return new WaitForSeconds(0.4f);

        //    monster.ExplosionCharacterMonster();
        //    isAttack = false;
        //}
    }
}
