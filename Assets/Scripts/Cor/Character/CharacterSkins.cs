using System.Collections.Generic;
using UnityEngine;

namespace PlayKing.Cor
{
    public class CharacterSkins : MonoBehaviour
    {
        [Header("Skins")]
        [SerializeField] List<GameObject> skins = new List<GameObject>();
        [SerializeField] CharacterMonsterType _skinType;

        public CharacterMonsterType Type()
        {
            return _skinType;
        }

        public void SetType(CharacterMonsterType t)
        {
            _skinType = t;
            SetCharacterSkin(_skinType);
        }

        public void SetCharacterSkin(CharacterMonsterType _characterSkinType)
        {
            switch (_characterSkinType)
            {
                case CharacterMonsterType.HuggyWuggy:
                    skins[0].SetActive(true);
                    break;
                case CharacterMonsterType.MotherSpider:
                    skins[1].SetActive(true);
                    break;
                case CharacterMonsterType.Baldy:
                    skins[2].SetActive(true);
                    break;
                case CharacterMonsterType.CartoonCat:
                    skins[3].SetActive(true);
                    break;
                case CharacterMonsterType.Siren:
                    skins[4].SetActive(true);
                    break;
                case CharacterMonsterType.Venom:
                    skins[5].SetActive(true);
                    break;
            }
        }
    }
}
