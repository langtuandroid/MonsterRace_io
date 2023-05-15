using UnityEngine;

namespace Core
{
    public class TableChooseParts : MonoBehaviour
    {
        [SerializeField] PartsSkinSaver partsSkinSaver;

        public bool CheckPartsOpen(string idSkin)
        {
            foreach(var i in partsSkinSaver.GetIDS())
            {
                if (i == idSkin)
                    return true;
            }
            return false;
        }
    }
}
