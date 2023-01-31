using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace BlueStellar.Cor
{
    public class BallsMonster : MonoBehaviour
    {
        [SerializeField] GameObject bodyMonster;
        [SerializeField] List<GameObject> montserHeads = new List<GameObject>();
        [SerializeField] List<GameObject> balls = new List<GameObject>();
        [SerializeField] Weapon weapon;
        [SerializeField] Animator anim;
        [SerializeField] private string namePose;
        [SerializeField] private float scale;

        [SerializeField] PlayerFight _playerFight;
        [SerializeField] BotFight _botFight;

        public List<GameObject> Balls()
        {
            return balls;
        }

        public void MonsterActive()
        {
            anim.SetTrigger(namePose);
            transform.localScale = new Vector3(scale, scale, scale);
        }

        public void ActiveMontserHead(CharacterMonsterType monsterType)
        {
            switch (monsterType)
            {
                case CharacterMonsterType.HuggyWuggy:
                    montserHeads[0].SetActive(true);
                    break;
                case CharacterMonsterType.MotherSpider:
                    montserHeads[1].SetActive(true);
                    break;
                case CharacterMonsterType.Baldy:
                    montserHeads[2].SetActive(true);
                    break;
                case CharacterMonsterType.CartoonCat:
                    montserHeads[3].SetActive(true);
                    break;
                case CharacterMonsterType.Siren:
                    montserHeads[4].SetActive(true);
                    break;
                case CharacterMonsterType.Venom:
                    montserHeads[5].SetActive(true);
                    break;
            }
        }

        public void AddPhysicsBalls()
        {
            weapon.gameObject.SetActive(true);

            foreach (var i in balls)
            {
                i.AddComponent<MonsterBall>();
            }

            if (GetComponentInParent<PlayerFight>() != null)
            {
                _playerFight = GetComponentInParent<PlayerFight>();
                _playerFight.SetWeapon(weapon);
            }

            if (GetComponentInParent<BotFight>() != null)
            {
                _botFight = GetComponentInParent<BotFight>();
                _botFight.SetWeapon(weapon);
            }
            bodyMonster.SetActive(false);
        }
    }
}