using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace BlueStellar.Cor
{
    public class KnockLet : MonoBehaviour
    {
        private void OnTriggerEnter(Collider other)
        {
            if(other.gameObject.tag == "Character")
            {
                if(other.GetComponent<Character>())
                other.GetComponent<Character>().KnockCharacter(transform);
            }
        }
    }
}
