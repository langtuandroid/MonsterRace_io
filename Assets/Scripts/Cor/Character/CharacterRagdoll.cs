using UnityEngine;

namespace PlayKing.Cor
{
    public class CharacterRagdoll : MonoBehaviour
    {
        [SerializeField] Rigidbody[] spines;

        public void ActiveteRagdoll(Transform target)
        {
            foreach(var i in spines)
            {
                i.isKinematic = false;
                Vector3 dir = i.position - target.position;

                i.AddForce(new Vector3(dir.x * 3f, dir.y * 7f, dir.z * 3f), ForceMode.Impulse);
            }
        }

        public void ON()
        {
            foreach (var i in spines)
            {
                i.drag = 12f; ;
                i.gameObject.GetComponent<Collider>().enabled = false;
            }
        }
    }
}
