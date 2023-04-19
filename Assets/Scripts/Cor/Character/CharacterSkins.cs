using System.Collections.Generic;
using UnityEngine;

namespace Cor
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

        public void SetType(CharacterMonsterType type)
        {
            _skinType = type;
            SetCharacterSkin(_skinType);
        }

        public void SetCharacterSkin(CharacterMonsterType _characterSkinType)
        {
            switch (_characterSkinType)
            {
                case CharacterMonsterType.HuggyWuggy:
                    skins[0].SetActive(true);
                    break;
                case CharacterMonsterType.CartoonCat:
                    skins[1].SetActive(true);
                    break;
                case CharacterMonsterType.Siren:
                    skins[2].SetActive(true);
                    break;
                case CharacterMonsterType.Baldy:
                    skins[3].SetActive(true);
                    break;
                case CharacterMonsterType.CartoonDog:
                    skins[4].SetActive(true);
                    break;
                case CharacterMonsterType.KissyMissy:
                    skins[5].SetActive(true);
                    break;
                case CharacterMonsterType.BunzoBunny:
                    skins[6].SetActive(true);
                    break;
                case CharacterMonsterType.EvilSonnik:
                    skins[7].SetActive(true);
                    break;
                case CharacterMonsterType.Freddy:
                    skins[8].SetActive(true);
                    break;
                case CharacterMonsterType.MotherSpider:
                    skins[9].SetActive(true);
                    break;
                case CharacterMonsterType.Venom:
                    skins[10].SetActive(true);
                    break;
            }
        }
    }
}
