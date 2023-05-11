using UnityEngine;

namespace Cor
{
    public class TableChooseParts : MonoBehaviour
    {
        [SerializeField] PartsSkinSaver _partsSkinSaver;

        public bool CheckPartsOpen(string idSkin)
        {
            foreach(var i in _partsSkinSaver.GetIDS())
            {
                if (i == idSkin)
                    return true;
            }
            return false;
        }
    }
}
