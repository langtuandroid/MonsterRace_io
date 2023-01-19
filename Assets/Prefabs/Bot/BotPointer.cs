using UnityEngine;

namespace PlayKing.Cor
{
    public class BotPointer : MonoBehaviour
    {
        [SerializeField] CharacterStates _characterStates;
        
        private void Start()
        {
            PointerController.Instance.AddToList(this);
        }

        public void Remove()
        {
            PointerController.Instance.RemoveFromList(this);
        }
    }
}
