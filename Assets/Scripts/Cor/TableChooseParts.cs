using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace BlueStellar.Cor
{
    public class TableChooseParts : MonoBehaviour
    {
        [SerializeField] List<SkinPart> skinParts = new List<SkinPart>();
        [SerializeField] GameObject[] locks;
        [SerializeField] PartsSkinSaver _partsSkinSaver;
        [SerializeField] List<string> st = new List<string>();

        private void Start()
        {
            CheckPartsOpen();
        }

        private void CheckPartsOpen()
        {
            st = _partsSkinSaver.GetIDS();

            for(int i = 0; i < skinParts.Count; i++)
            {
                if(skinParts[i].GetIDPart() == st[i])
                {
                    locks[i].SetActive(false);
                    skinParts[i].gameObject.SetActive(true);
                }
            }
        }
    }
}
