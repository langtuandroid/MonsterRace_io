using System.Collections.Generic;
using UnityEngine;

namespace Cor
{
    public class BallsMonster : MonoBehaviour
    {
        [SerializeField] GameObject bodyMonster;
        [SerializeField] List<GameObject> montserHeads = new List<GameObject>();
        [SerializeField] List<GameObject> balls = new List<GameObject>();
        [SerializeField] Transform pointWeapon;
        [SerializeField] Animator anim;
        [SerializeField] private string namePose;
        [SerializeField] private float scale;

        private Weapon _weapon;
        private WeaponSpawner _weaponSpawner;
        private PlayerFight _playerFight;
        private BotFight _botFight;

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
                case CharacterMonsterType.CartoonCat:
                    montserHeads[1].SetActive(true);
                    break;
                case CharacterMonsterType.Siren:
                    montserHeads[2].SetActive(true);
                    break;
                case CharacterMonsterType.Baldy:
                    montserHeads[3].SetActive(true);
                    break;
                case CharacterMonsterType.CartoonDog:
                    montserHeads[4].SetActive(true);
                    break;
                case CharacterMonsterType.KissyMissy:
                    montserHeads[5].SetActive(true);
                    break;
                case CharacterMonsterType.BunzoBunny:
                    montserHeads[6].SetActive(true);
                    break;
                case CharacterMonsterType.EvilSonnik:
                    montserHeads[7].SetActive(true);
                    break;
                case CharacterMonsterType.Freddy:
                    montserHeads[8].SetActive(true);
                    break;
                case CharacterMonsterType.Foxy:
                    montserHeads[9].SetActive(true);
                    break;
                case CharacterMonsterType.FreddyRabbit:
                    montserHeads[10].SetActive(true);
                    break;
                case CharacterMonsterType.MotherSpider:
                    montserHeads[11].SetActive(true);
                    break;
                case CharacterMonsterType.RoxanneWolf:
                    montserHeads[12].SetActive(true);
                    break;
                case CharacterMonsterType.CircusBaldy:
                    montserHeads[13].SetActive(true);
                    break;
                case CharacterMonsterType.Animatronic:
                    montserHeads[14].SetActive(true);
                    break;
                case CharacterMonsterType.Demorgoron:
                    montserHeads[15].SetActive(true);
                    break;
                case CharacterMonsterType.Vecna:
                    montserHeads[16].SetActive(true);
                    break;
                case CharacterMonsterType.Venom:
                    montserHeads[17].SetActive(true);
                    break;
                case CharacterMonsterType.GlamrockFreddy:
                    montserHeads[18].SetActive(true);
                    break;
                case CharacterMonsterType.ToyChica:
                    montserHeads[19].SetActive(true);
                    break;
                case CharacterMonsterType.BlueFriend:
                    montserHeads[20].SetActive(true);
                    break;
                case CharacterMonsterType.GreenFriend:
                    montserHeads[21].SetActive(true);
                    break;
                case CharacterMonsterType.Tanos:
                    montserHeads[22].SetActive(true);
                    break;
            }
        }

        public void SetupMonster(bool ok)
        {
            bodyMonster.SetActive(false);

            foreach (var i in balls)
            {
                i.AddComponent<MonsterBall>();
            }

            _weaponSpawner = GameObject.FindObjectOfType<WeaponSpawner>();
            if(ok)
                _weapon = _weaponSpawner.SpawnWeapon(pointWeapon, _weaponSpawner.GetIndex());
            if(!ok)
                _weapon = _weaponSpawner.SpawnWeapon(pointWeapon, Random.Range(0, 4));
            if (GetComponentInParent<PlayerFight>() != null)
            {
                _playerFight = GetComponentInParent<PlayerFight>();
                _playerFight.SetWeapon(_weapon);
            }

            if (GetComponentInParent<BotFight>() != null)
            {
                _botFight = GetComponentInParent<BotFight>();
                _botFight.SetWeapon(_weapon);
            }
        }
    }
}