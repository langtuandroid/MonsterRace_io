using System.Collections.Generic;
using UnityEngine;

namespace Cor
{
    public class TableChooseParts : MonoBehaviour
    {
        [SerializeField] List<SkinPart> skinParts = new List<SkinPart>();
        [SerializeField] GameObject[] locks;
        [SerializeField] PartsSkinSaver _partsSkinSaver;
        private List<string> skinsIDS = new List<string>();

        private void Start()
        {
            CheckPartsOpen();
        }

        private void CheckPartsOpen()
        {
            skinsIDS = _partsSkinSaver.GetIDS();

            for(int i = 0; i < skinParts.Count; i++)
            {
                if(skinParts[i].GetIDPart() == skinsIDS[i])
                {
                    locks[i].SetActive(false);
                    skinParts[i].gameObject.SetActive(true);
                }
            }
        }
    }
}
