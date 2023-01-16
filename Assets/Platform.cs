using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PlayKing.Cor
{
    public class Platform : MonoBehaviour
    {
        private void OnCollisionEnter(Collision collision)
        {
            if (collision.gameObject.CompareTag("Ball"))
            {
                if(collision.gameObject.GetComponent<CollectableBall>() != null)
                {
                    collision.gameObject.GetComponent<CollectableBall>().Normal();
                }
            }
        }
    }
}
