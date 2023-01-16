using UnityEngine;

namespace PlayKing.Cor
{
    public class BotPointer : MonoBehaviour
    {
        [SerializeField] CharacterStates _characterStates;
        
        private void Start()
        {
            PointerController.Instance.AddToList(this);
            _characterStates.OnDie.AddListener(Remove);
        }

        private void Remove()
        {
            PointerController.Instance.RemoveFromList(this);
        }
    }
}
