using System.Collections.Generic;
using UnityEngine;

namespace BlueStellar.Cor
{
    public class PlayerCharacterSkin : MonoBehaviour
    {
        [System.Serializable]
        public class PartsSkin
        {
            public CharacterMonsterType skinType;
            public GameObject head;
            public GameObject arms;
            public GameObject body;
            public GameObject legs;
        }

        #region Variables

        [SerializeField] List<PartsSkin> skins = new List<PartsSkin>();
        [SerializeField] CharacterMonsterType _headType;
        [SerializeField] CharacterMonsterType _armsType;
        [SerializeField] CharacterMonsterType _bodyType;
        [SerializeField] CharacterMonsterType _legsType;

        #endregion

        public CharacterMonsterType GetHeadType()
        {
            return _headType;
        }

        private void Start()
        {
            LoadSkin();
            CollectSkinChange();
        }

        private void CollectSkinChange()
        {
            foreach(var i in skins)
            {
                if (i.skinType == _headType) i.head.SetActive(true);
                if (i.skinType == _armsType) i.arms.SetActive(true);
                if (i.skinType == _bodyType) i.body.SetActive(true);
                if (i.skinType == _legsType) i.legs.SetActive(true);
            }
        }

        #region Load&Save

        private void LoadSkin()
        {
            _headType = ES3.Load("_headType", _headType);
            _bodyType = ES3.Load("_bodyType", _bodyType);
            _armsType = ES3.Load("_armsType", _armsType);
            _legsType = ES3.Load("_legsType", _legsType);
        }

        private void SaveSkin()
        {
            ES3.Save("_headType", _headType);
            ES3.Save("_bodyType", _bodyType);
            ES3.Save("_armsType", _armsType);
            ES3.Save("_legsType", _legsType);
        }

        #endregion
    }
}
