using UnityEngine;
using TMPro;

namespace Core
{
    public class NameGenerator : MonoBehaviour
    {
        #region Variables

        [SerializeField] private TextMeshProUGUI _textName;
        [SerializeField] private string[] names;
        private string _name;

        #endregion

        public string Name()
        {
            return _name;
        }

        private void Start()
        {
            var randomIndex = Random.Range(0, names.Length);
            _textName.text = names[randomIndex];
            _name = names[randomIndex];
        }
    }
}
