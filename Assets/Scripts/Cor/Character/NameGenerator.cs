using UnityEngine;
using TMPro;

namespace PlayKing.Cor
{
    public class NameGenerator : MonoBehaviour
    {
        [SerializeField] TextMeshProUGUI textName;
        [SerializeField] string[] names;

        private void Start()
        {
            int randomIndex = Random.Range(0, names.Length);
            textName.text = names[randomIndex];
        }
    }
}
