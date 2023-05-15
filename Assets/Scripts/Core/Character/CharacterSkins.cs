using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

namespace Core
{
    public class CharacterSkins : MonoBehaviour
    {
        #region Variables
        
        [Header("Skins")]
        [SerializeField] private List<GameObject> skins;
        [SerializeField] private CharacterMonsterType skinType;

        #endregion

        public CharacterMonsterType Type()
        {
            return skinType;
        }

        public void SetType(CharacterMonsterType type)
        {
            skinType = type;
            SetCharacterSkin(skinType);
        }

        public void RandomSkin()
        {
            skins[Random.Range(0, skins.Count)].SetActive(true);
        }

        private void SetCharacterSkin(CharacterMonsterType characterSkinType)
        {
            switch (characterSkinType)
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
                case CharacterMonsterType.Foxy:
                    break;
                case CharacterMonsterType.FreddyRabbit:
                    break;
                case CharacterMonsterType.RoxanneWolf:
                    break;
                case CharacterMonsterType.CircusBaldy:
                    break;
                case CharacterMonsterType.Animatronic:
                    break;
                case CharacterMonsterType.Demorgoron:
                    break;
                case CharacterMonsterType.Vecna:
                    break;
                case CharacterMonsterType.GlamrockFreddy:
                    break;
                case CharacterMonsterType.ToyChica:
                    break;
                case CharacterMonsterType.BlueFriend:
                    break;
                case CharacterMonsterType.GreenFriend:
                    break;
                case CharacterMonsterType.OrangeFriend:
                    break;
                case CharacterMonsterType.PurpleFriend:
                    break;
                case CharacterMonsterType.RedFriend:
                    break;
                case CharacterMonsterType.Tanos:
                    break;
            }
        }
    }
}
