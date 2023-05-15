using System.Collections.Generic;
using UnityEngine;

namespace Core
{
    public class BallsMonster : MonoBehaviour
    {
        #region Variables

        [SerializeField] private GameObject bodyMonster;
        [SerializeField] private List<GameObject> montserHeads;
        [SerializeField] private List<GameObject> balls;
        [SerializeField] private Transform pointWeapon;
        [SerializeField] private Animator anim;
        [SerializeField] private string namePose;
        [SerializeField] private float scale;
        
        private WeaponSpawner _weaponSpawner;
        private CharacterFight _characterFight;

        #endregion

        public List<GameObject> GetBalls()
        {
            return balls;
        }

        public void MonsterActive()
        {
            anim.SetTrigger(namePose);
            transform.localScale = new Vector3(scale, scale, scale);
        }

        public void ActiveMonsterHead(CharacterMonsterType monsterType)
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

            _weaponSpawner = FindObjectOfType<WeaponSpawner>();
            Weapon _weapon = new Weapon();
            if(ok)
                _weapon = _weaponSpawner.SpawnWeapon(pointWeapon, _weaponSpawner.GetIndex());
            if(!ok)
                _weapon = _weaponSpawner.SpawnWeapon(pointWeapon, Random.Range(0, 4));
        }
    }
}