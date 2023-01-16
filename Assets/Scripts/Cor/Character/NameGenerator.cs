using UnityEngine;
using TMPro;

namespace PlayKing.Cor
{
    public class NameGenerator : MonoBehaviour
    {
        [SerializeField] TextMeshProUGUI textName;
        [SerializeField] string[] names;
        string d;
        public string Name()
        {
            return d;
        }

        private void Start()
        {
            int randomIndex = Random.Range(0, names.Length);
            textName.text = names[randomIndex];
            d = names[randomIndex];
        }
    }
}
