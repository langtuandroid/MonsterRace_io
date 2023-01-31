using UnityEngine;
using UnityEngine.UI;

namespace BlueStellar.Cor
{
    public class NameChanger : MonoBehaviour
    {
        [SerializeField] InputField inputField;
        [SerializeField] PlayerName _playerName;

        private void Start()
        {
            _playerName = GameObject.FindObjectOfType<PlayerName>();
            //inputField.onSubmit(_playerName.NewName();
        }

        public void ChangeName()
        {
            _playerName.NewName(inputField.text);
        }
    }
}
