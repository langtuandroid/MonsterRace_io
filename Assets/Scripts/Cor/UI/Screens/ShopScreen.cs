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
        [SerializeField] GameObject ballsGroup;
        [SerializeField] GameObject weaponGroup;
        [SerializeField] Toggle tabBalls;
        [SerializeField] Toggle tabWeapons;
        [SerializeField] TestLobby testLobby;

        #endregion

        public void ActiveShop()
        {
            gameObject.SetActive(true);
            shopCam.SetActive(true);
            lockObj.SetActive(true);
            shopTitle.transform.DOLocalMoveY(0f, 0.7f).From(-1640f).OnComplete(() => bg.SetActive(true));
            bonusTitle.transform.DOScale(bonusTitle.transform.localScale, 0.7f).From(0).SetDelay(0.5f);
            bonusButton.transform.DOPunchScale(new Vector3(0.1f, 0.1f, 0.1f), 1f, 1).SetEase(Ease.Linear).SetLoops(-1);
        }

        public void DeactvieShop()
        {
            shopCam.SetActive(false);
            bg.SetActive(false);
            lockObj.SetActive(false);
            shopTitle.transform.DOLocalMoveY(-1640f, 0.7f).OnComplete(() => gameObject.SetActive(false));
        }

        public void ActiveBallsGroup()
        {
            ballsGroup.SetActive(true);
            weaponGroup.SetActive(false);
            tabWeapons.isOn = false;
            testLobby.SetTest(false);
        }

        public void ActiveWeaponGroup()
        {
            ballsGroup.SetActive(false);
            weaponGroup.SetActive(true);
            tabBalls.isOn = false;
            testLobby.SetTest(true);
        }
    }
}
