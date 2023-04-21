using UnityEngine;
using DG.Tweening;

namespace Cor
{
    public class ShopScreen : MonoBehaviour
    {
        #region Variables

        [SerializeField] GameObject shopTitle;
        [SerializeField] GameObject bonusButton;
        [SerializeField] GameObject lockObj;

        #endregion

        public void ActiveShop()
        {
            gameObject.SetActive(true);
            lockObj.SetActive(true);
            shopTitle.transform.DOLocalMoveY(0f, 0.7f).From(-1640f);
            bonusButton.transform.DOScale(bonusButton.transform.localScale, 0.7f).From(0).SetDelay(0.5f);
        }

        public void DeactvieShop()
        {
            lockObj.SetActive(false);
            shopTitle.transform.DOLocalMoveY(-1640f, 0.7f).OnComplete(() => gameObject.SetActive(false));
        }
    }
}
