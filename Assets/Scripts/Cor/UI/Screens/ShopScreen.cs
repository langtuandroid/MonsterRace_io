using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

namespace Cor
{
    public class ShopScreen : MonoBehaviour
    {
        #region Variables

        [SerializeField] GameObject shopTitle;
        [SerializeField] GameObject bg;
        [SerializeField] GameObject shopCam;
        [SerializeField] GameObject bonusTitle;
        [SerializeField] GameObject bonusButton;
        [SerializeField] GameObject lockObj;
        [SerializeField] GameObject weaponGroup;
        [SerializeField] GameObject ballsGroup;
        [SerializeField] GameObject skinsGroup;
        [SerializeField] ShopItems _shopItems;
        [SerializeField] Image[] imgs;
        [SerializeField] Color selected;

        #endregion

        public void ActiveShop()
        {
            gameObject.SetActive(true);
            shopCam.SetActive(true);
            lockObj.SetActive(true);
            shopTitle.transform.DOLocalMoveY(0f, 0.7f).From(-1640f).OnComplete(() => bg.SetActive(true));
            bonusTitle.transform.DOScale(bonusTitle.transform.localScale, 0.7f).From(0).SetDelay(0.5f);
            bonusButton.transform.DOPunchScale(new Vector3(0.1f, 0.1f, 0.1f), 1f, 1).SetEase(Ease.Linear).SetLoops(-1);
            ActiveWeaponGroup();
        }

        public void DeactvieShop()
        {
            shopCam.SetActive(false);
            bg.SetActive(false);
            lockObj.SetActive(false);
            shopTitle.transform.DOLocalMoveY(-1640f, 0.7f).OnComplete(() => gameObject.SetActive(false));
        }

        public void ActiveWeaponGroup()
        {
            weaponGroup.SetActive(true);
            ballsGroup.SetActive(false);
            skinsGroup.SetActive(false);
            imgs[0].color = Color.white;
            imgs[1].color = selected;
            imgs[2].color = selected;
            _shopItems.ActiveGroup(0);
        }

        public void ActiveBallsGroup()
        {
            weaponGroup.SetActive(false);
            ballsGroup.SetActive(true);
            skinsGroup.SetActive(false);
            imgs[1].color = Color.white;
            imgs[0].color = selected;
            imgs[2].color = selected;
            _shopItems.ActiveGroup(1);
        }

        public void ActiveSkinsGroup()
        {
            weaponGroup.SetActive(false);
            ballsGroup.SetActive(false);
            skinsGroup.SetActive(true);
            imgs[2].color = Color.white;
            imgs[0].color = selected;
            imgs[1].color = selected;
            _shopItems.ActiveGroup(2);
        }
    }
}
