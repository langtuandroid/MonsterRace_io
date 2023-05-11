using UnityEngine;
using UnityEngine.UI;

namespace Cor
{
    public class NameChanger : MonoBehaviour
    {
        #region Variables

        [SerializeField] InputField inputField;
        [SerializeField] PlayerName _playerName;

        #endregion

        private void Start()
        {
            if(_playerName.Name() != "PLAYER")
                inputField.text = _playerName.Name();
        }

        public void ChangeName() => _playerName.NewName(inputField.text);
    }
}
