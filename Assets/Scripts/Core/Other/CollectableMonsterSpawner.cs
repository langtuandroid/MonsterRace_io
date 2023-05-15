using System.Collections.Generic;
using UnityEngine;

namespace Core
{
    public class CollectableMonsterSpawner : MonoBehaviour
    {
        [SerializeField] List<GameObject> monsters = new List<GameObject>();

        public void NewMonster(CharacterMonsterType monsterType, CollectableMonster collectableMonster, Transform pointSpawn)
        {
            switch (monsterType)
            {
                case CharacterMonsterType.HuggyWuggy:
                    MonsterSpawn(monsters[0], collectableMonster, pointSpawn);
                    break;
                case CharacterMonsterType.CartoonCat:
                    MonsterSpawn(monsters[1], collectableMonster, pointSpawn);
                    break;
                case CharacterMonsterType.Siren:
                    MonsterSpawn(monsters[2], collectableMonster, pointSpawn);
                    break;
                case CharacterMonsterType.Baldy:
                    MonsterSpawn(monsters[3], collectableMonster, pointSpawn);
                    break;
                case CharacterMonsterType.CartoonDog:
                    MonsterSpawn(monsters[4], collectableMonster, pointSpawn);
                    break;
                case CharacterMonsterType.KissyMissy:
                    MonsterSpawn(monsters[5], collectableMonster, pointSpawn);
                    break;
                case CharacterMonsterType.BunzoBunny:
                    MonsterSpawn(monsters[6], collectableMonster, pointSpawn);
                    break;
                case CharacterMonsterType.EvilSonnik:
                    MonsterSpawn(monsters[7], collectableMonster, pointSpawn);
                    break;
                case CharacterMonsterType.Freddy:
                    MonsterSpawn(monsters[8], collectableMonster, pointSpawn);
                    break;
                case CharacterMonsterType.MotherSpider:
                    MonsterSpawn(monsters[9], collectableMonster, pointSpawn);
                    break;
                case CharacterMonsterType.Venom:
                    MonsterSpawn(monsters[10], collectableMonster, pointSpawn);
                    break;
            }
        }

        private void MonsterSpawn(GameObject montser, CollectableMonster collectableMonster, Transform pointSpawn)
        {
            GameObject newMonster = Instantiate(montser, pointSpawn.position, Quaternion.identity);
            newMonster.transform.parent = pointSpawn;
            collectableMonster.SetBallsMonster(newMonster.GetComponent<BallsMonster>());
        }
    }
}
