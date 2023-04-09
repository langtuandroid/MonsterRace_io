using UnityEngine;

namespace Cor
{
    public class DestroyedField : MonoBehaviour
    {
        private void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("Ball"))
            {
                Destroy(other.gameObject);
            }
        }
    }
}
