using System.Collections.Generic;
using UnityEngine;

public enum CharacterSkinType
{
    HuggyWuggy,
    Baldy,
    MotherSpider,
    CartoonCat,
    Siren,
    Venom
}

namespace PlayKing.Cor
{
    public class CharacterSkins : MonoBehaviour
    {
        [Header("Skins")]
        [SerializeField] List<GameObject> huggyWaggySkin = new List<GameObject>();
        [SerializeField] List<GameObject> baldySkin = new List<GameObject>();
        [SerializeField] List<GameObject> motherSpiderSkin = new List<GameObject>();
        [SerializeField] List<GameObject> cartoonCatSkin = new List<GameObject>();
        [SerializeField] List<GameObject> sirenSkin = new List<GameObject>();
        [SerializeField] List<GameObject> venomSkin = new List<GameObject>();
        [SerializeField] CharacterSkinType _skinType;
        [SerializeField] Material colorDie;

        private void Start()
        {
            SetCharacterSkin(_skinType);
        }

        public void SetCharacterSkin(CharacterSkinType _characterSkinType)
        {
            switch (_characterSkinType)
            {
                case CharacterSkinType.HuggyWuggy:
                    foreach(var i in huggyWaggySkin) { i.SetActive(true); }
                    break;
                case CharacterSkinType.Baldy:
                    foreach (var i in baldySkin) { i.SetActive(true); }
                    break;
                case CharacterSkinType.MotherSpider:
                    foreach (var i in motherSpiderSkin) { i.SetActive(true); }
                    break;
                case CharacterSkinType.CartoonCat:
                    foreach (var i in cartoonCatSkin) { i.SetActive(true); }
                    break;
                case CharacterSkinType.Siren:
                    foreach (var i in sirenSkin) { i.SetActive(true); }
                    break;
                case CharacterSkinType.Venom:
                    foreach (var i in venomSkin) { i.SetActive(true); }
                    break;
            }
        }

        public void ChangeDieSkin()
        {
            switch (_skinType)
            {
                case CharacterSkinType.HuggyWuggy:
                    foreach (var i in huggyWaggySkin) { i.GetComponent<SkinnedMeshRenderer>().material = colorDie; }
                    break;
                case CharacterSkinType.Baldy:
                    foreach (var i in baldySkin) { i.GetComponent<SkinnedMeshRenderer>().material = colorDie; }
                    break;
                case CharacterSkinType.MotherSpider:
                    foreach (var i in motherSpiderSkin) { i.GetComponent<SkinnedMeshRenderer>().material = colorDie; }
                    break;
                case CharacterSkinType.CartoonCat:
                    foreach (var i in cartoonCatSkin) { i.GetComponent<SkinnedMeshRenderer>().material = colorDie; }
                    break;
                case CharacterSkinType.Siren:
                    foreach (var i in sirenSkin) { i.GetComponent<SkinnedMeshRenderer>().material = colorDie; }
                    break;
                case CharacterSkinType.Venom:
                    foreach (var i in venomSkin) { i.GetComponent<SkinnedMeshRenderer>().material = colorDie; }
                    break;
            }
        }
    }
}
