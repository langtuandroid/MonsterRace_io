using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PlayKing.Cor
{
    public class CharacterMonster : MonoBehaviour
    {
        [SerializeField] List<MonsterBall> currencyBalls = new List<MonsterBall>();
        CharacterStates _characterStates;
        
        private void Start()
        {
            _characterStates = GetComponentInParent<CharacterStates>();
        }

        public void AddMonsterBall(MonsterBall monsterBall)
        {
            currencyBalls.Add(monsterBall);
        }

        public void ExplosionCharacterMonster()
        {
            foreach(var i in currencyBalls)
            {
                Vector3 dirImpulse = transform.position - i.transform.position;
                i.Explosion(dirImpulse);
                i.transform.parent = null;
            }

            _characterStates.CharacterDie();
            _characterStates.Die();
        }

        public bool isPlayer;
        public void Stopped()
        {
            _characterStates.Stop();    
        }

        private void OnTriggerEnter(Collider other)
        {
            if (other.gameObject.CompareTag("Character"))
            {
                if (isAttack)
                    return;

                _characterStates.Attack();
                StartCoroutine(Kill(other.GetComponent<Character>()));
                isAttack = true;
            }

            if (other.gameObject.CompareTag("Monster"))
            {
                if (!isPlayer)
                    return;

                if (isAttack)
                    return;
                
                CharacterMonster monster = other.GetComponent<CharacterMonster>();

                _characterStates.Attack();
                monster.Stopped();
                monster.transform.LookAt(transform);
                StartCoroutine(IE_KillMonster(monster));
                isAttack = true;
            }
        }
        private bool isAttack;
        private IEnumerator Kill(Character character)
        {
            yield return new WaitForSeconds(0.4f);

            character.KillCharacter(transform);
            isAttack = false;
        }

        private IEnumerator IE_KillMonster(CharacterMonster monster)
        {
            yield return new WaitForSeconds(0.4f);

            monster.ExplosionCharacterMonster();
            isAttack = false;
        }
    }
}
