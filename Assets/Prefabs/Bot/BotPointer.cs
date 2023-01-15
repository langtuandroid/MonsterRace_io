using UnityEngine;

namespace PlayKing.Cor
{
    public class BotPointer : MonoBehaviour
    {
        CharacterStates _characterStates;
        private void Start()
        {
            _characterStates = GetComponentInChildren<CharacterStates>();
            PointerController.Instance.AddToList(this);
            _characterStates.OnDie.AddListener(Remove);
        }

        private void Remove()
        {
            PointerController.Instance.RemoveFromList(this);
        }
    }
}
