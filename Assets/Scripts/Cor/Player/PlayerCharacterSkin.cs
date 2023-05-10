using System.Collections.Generic;
using UnityEngine;

namespace Cor
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
        [SerializeField] private bool isLobby;

        #endregion

        public CharacterMonsterType GetHeadType()
        {
            return _headType;
        }

        private void Start()
        {
            if (!isLobby)
            {
                LoadSkin();
                CollectSkinChange();
            }
        }

        #region CollectableSkin

        public void AddHeadPart(CharacterMonsterType partType)
        {
            foreach(var i in skins)
            {
                if (i.skinType == partType)
                    i.head.SetActive(true);
            }
            _headType = partType;
            SaveSkin();
        }

        public void AddArmsPart(CharacterMonsterType partType)
        {
            foreach (var i in skins)
            {
                if (i.skinType == partType)
                    i.arms.SetActive(true);
            }
            _armsType = partType;
            SaveSkin();
        }

        public void AddBodyPart(CharacterMonsterType partType)
        {
            foreach (var i in skins)
            {
                if (i.skinType == partType)
                    i.body.SetActive(true);
            }
            _bodyType = partType;
            SaveSkin();
        }

        public void AddLegsPart(CharacterMonsterType partType)
        {
            foreach (var i in skins)
            {
                if (i.skinType == partType)
                    i.legs.SetActive(true);
            }
            _legsType = partType;
            SaveSkin();
        }

        public void DeactiveAllParts()
        {
            foreach(var i in skins)
            {
                i.head.SetActive(false);
                i.body.SetActive(false);
                i.arms.SetActive(false);
                i.legs.SetActive(false);
            }
        }

        #endregion

        public void CollectSkinChange()
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
