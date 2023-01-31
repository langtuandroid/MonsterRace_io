using UnityEngine;

namespace BlueStellar.Cor
{
    [RequireComponent(typeof(Rigidbody), typeof(SphereCollider))]
    public class MonsterBall : MonoBehaviour
    {
        [SerializeField] MeshRenderer meshRenderer;
        [SerializeField] private float force;
        [SerializeField] private bool isHeadBall;

        Rigidbody _rb;
        MonsterSpine _monsterSpine;

        public bool IsHeadBall()
        {
            return isHeadBall;
        }

        private void Start()
        {
            _rb = GetComponent<Rigidbody>();
            _rb.isKinematic = true;
            _monsterSpine = GetComponentInParent<MonsterSpine>();
            _monsterSpine.AddBallsToSpine(this);
        }

        public void Explosion(Vector3 dir)
        {
            transform.parent = null;
            _rb.isKinematic = false;
            _rb.AddForce(dir * force, ForceMode.Impulse);
        }
    }
}
