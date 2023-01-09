using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PlayKing.Cor
{
    [RequireComponent(typeof(Rigidbody))]
    public class MonsterBall : MonoBehaviour
    {
        [SerializeField] private float force;

        Rigidbody _rb;
        CharacterMonster _characterMonster;

        private void Start()
        {
            _rb = GetComponent<Rigidbody>();
            _characterMonster = GetComponentInParent<CharacterMonster>();
            _characterMonster.AddMonsterBall(this);
        }

        public void Explosion(Vector3 dir)
        {
            transform.parent = null;
            _rb.isKinematic = false;
            _rb.AddForce(dir * force, ForceMode.Impulse);
        }
    }
}
