using UnityEngine;
using UnityEngine.UI;

namespace Cor
{
    public class NameChanger : MonoBehaviour
    {
        [SerializeField] InputField inputField;
        [SerializeField] PlayerName _playerName;

        private void Start()
        {
            if(_playerName.Name() != "PLAYER")
                inputField.text = _playerName.Name();
        }

        public void ChangeName()
        {
            _playerName.NewName(inputField.text);
        }
    }
}
