using UnityEngine;

namespace Core
{
    public class BotPointer : MonoBehaviour
    {
        private void Start() => PointerManager.Instance.AddToList(this);

        public void Remove() => PointerManager.Instance.RemoveFromList(this);
    }
}
