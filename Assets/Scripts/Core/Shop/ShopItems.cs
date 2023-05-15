using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Core
{
    public class ShopItems : MonoBehaviour
    {
        [System.Serializable]
        public class Parts
        {
           public SkinPart[] skinParts;
        }
        
        #region Variables

        [Header("ItemsGroups")]
        [SerializeField] GameObject[] group;

        [Space]
        [Header("WeaponsItems")]
        [SerializeField] GameObject[] monsterWeapons;
        [SerializeField] GameObject[] previewWeapons;

        [Space]
        [Header("BallsItems")]
        [SerializeField] GameObject colorBall;
        [SerializeField] GameObject[] bonusBalls;
        [SerializeField] GameObject phonBall;
        [SerializeField] GameObject[] phonBalls;
        [SerializeField] MeshRenderer[] ballsMesh;

        [Space]
        [Header("Skins")]
        [SerializeField] GameObject[] skins;
        [SerializeField] List<Parts> partsSkins = new List<Parts>();

        #endregion

        public void ActiveGroup(int indexGroup)
        {
            foreach(var i in group) { i.SetActive(false); }
            group[indexGroup].SetActive(true);
        }

        public void ActiveWeaponItem(int indexWeapon)
        {
            foreach(var i in monsterWeapons) { i.SetActive(false); }
            foreach(var i in previewWeapons) { i.SetActive(false); }

            monsterWeapons[indexWeapon].SetActive(true);
            previewWeapons[indexWeapon].SetActive(true);
        }

        public void ActiveBallItem()
        {
            colorBall.GetComponent<MeshRenderer>().material.color = BallSkins.Instance.GetColorSkin();
            colorBall.SetActive(true);
            foreach (var i in bonusBalls) { i.SetActive(false); }
            foreach (var i in phonBalls) { i.SetActive(false); }

            phonBall.SetActive(true);
            foreach(var i in ballsMesh) { i.material.color = BallSkins.Instance.GetColorSkin(); }
        }

        public void ActiveBonusBallsItem(int index)
        {
            colorBall.SetActive(false);
            foreach(var i in bonusBalls) { i.SetActive(false); }
            bonusBalls[index].SetActive(true);
            phonBall.SetActive(false);
            foreach (var i in phonBalls) { i.SetActive(false); }
            phonBalls[index].SetActive(true);
        }

        public void ActiveSkin(int index)
        {
            foreach(var i in skins)
            {
                i.SetActive(false);
            }

            skins[index].SetActive(true);
            foreach(var i in partsSkins[index].skinParts)
            {
                i.OpenPart();
            }
        }
    }
}
