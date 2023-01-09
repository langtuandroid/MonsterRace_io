using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PlayKing.Cor
{
    public class CharacterMonster : MonoBehaviour
    {
        [SerializeField] List<MonsterBall> currencyBalls = new List<MonsterBall>();

        public void AddMonsterBall(MonsterBall monsterBall)
        {
            currencyBalls.Add(monsterBall);
        }

        private void Update()
        {
            if (Input.GetMouseButtonDown(1))
            {
                ExplosionCharacterMonster();
            }
        }

        public void ExplosionCharacterMonster()
        {
            foreach(var i in currencyBalls)
            {
                Vector3 dirImpulse = transform.position - i.transform.position;
                i.Explosion(dirImpulse);
            }
        }
    }
}
