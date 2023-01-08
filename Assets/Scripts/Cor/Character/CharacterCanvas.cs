using UnityEngine;
using TMPro;

namespace PlayKing.Cor
{
    public class CharacterCanvas : MonoBehaviour
    {
        [SerializeField] Transform targetCharacter;
        [SerializeField] Transform targetMonster;

        private void Start()
        {
            transform.parent = null;
        }

        private void LateUpdate()
        {
            transform.position = targetCharacter.position;
        }
    }
}
