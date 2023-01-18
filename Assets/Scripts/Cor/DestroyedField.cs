using UnityEngine;

namespace PlayKing.Cor
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
