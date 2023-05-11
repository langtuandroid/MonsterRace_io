using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;

namespace Cor
{
    public class SkinPart : MonoBehaviour
    {
        #region Variables

        [Header("IDPart")]
        [SerializeField] private string idPart;

        [Space]
        [Header("PartType")]
        [SerializeField] CharacterMonsterType typePart;

        [Space]
        [Header("Lock")]
        [SerializeField] GameObject lockObj;

        [Space]
        [Header("RotatePart")]
        [SerializeField] Transform point;
        [SerializeField] private float speedRotate;
        [SerializeField] private float maxSpeedRotate;

        [Space]
        [Header("PartCanvas")]
        [SerializeField] GameObject canvas;

        [Space]
        [Header("RewardPart")]
        [SerializeField] GameObject buttonReward;
        [SerializeField] GameObject lockRWPopup;
        [SerializeField] GameObject loadIcon;
        [SerializeField] GameObject rwIcon;
        [SerializeField] Text counterRW;
        [SerializeField] private int ammountRW;
        [SerializeField] private int maxRW;
        [SerializeField] private bool isRewardPart;

        [Space]
        [Header("MoneyPart")]
        [SerializeField] GameObject buttonPrice;
        [SerializeField] Text counterMoney;
        [SerializeField] private int price;
        [SerializeField] private bool isMoneyPart;

        private bool isUp;
        private Vector3 positionOffset;
        private Vector3 startPos;
        private Camera _camera;
        private TableChooseParts _tableChoose;

        #endregion

        public string GetIDPart()
        {
            return idPart;
        }

        public CharacterMonsterType GetPartType()
        {
            return typePart;
        }

        private void Start()
        {
            _camera = Camera.main;
            _tableChoose = GameObject.FindObjectOfType<TableChooseParts>();
            bool openStatus = _tableChoose.CheckPartsOpen(idPart);
            gameObject.SetActive(openStatus);
            lockObj.SetActive(!openStatus);
            startPos = transform.position;
            LoadData();
            CheckPartForReward();
            CheckPartForPrice();
            if(!isMoneyPart && !isRewardPart)
                if (canvas != null) canvas.SetActive(false);
        }

        private void FixedUpdate()
        {
            if (!isRewardPart)
                return;

            if (AdsManager.IsReadyReward) 
            {
                loadIcon.SetActive(false);
                rwIcon.SetActive(true);
                return;
            }

            loadIcon.SetActive(true);
            rwIcon.SetActive(false);
        }

        private void Update()
        {
            point.transform.Rotate(0f, speedRotate, 0f);
        }

        public void OpenPart()
        {
            LoadData();
            isMoneyPart = false;
            isRewardPart = false;
            canvas.SetActive(false);
            Debug.Log("kl");
            SaveData();
        }

        #region PartMovement

        private Vector3 GetMousePosition()
        {
            return _camera.WorldToScreenPoint(transform.position);
        }

        private void OnMouseDown()
        {
            startPos = transform.position;
            speedRotate = 0f;
            positionOffset = Input.mousePosition - GetMousePosition();
            isUp = false;
        }

        private void OnMouseDrag()
        {
            Vector3 dragPos = transform.position;
            dragPos.x = _camera.ScreenToWorldPoint(Input.mousePosition - positionOffset).x;
            dragPos.y = _camera.ScreenToWorldPoint(Input.mousePosition - positionOffset).y;
            dragPos.z = _camera.ScreenToWorldPoint(Input.mousePosition - positionOffset).z;
            transform.position = dragPos;
        }

        private void OnMouseUp()
        {
            isUp = true;
            transform.DOMove(startPos, 0.5f).OnComplete(() => speedRotate = maxSpeedRotate);
        }

        #endregion

        #region PartCollision

        private void OnTriggerStay(Collider other)
        {
            if (other.CompareTag("Character"))
            {
                if (isUp)
                {
                    if (isRewardPart)
                    {
                        ChangeRW();
                        return;
                    }

                    if (isMoneyPart)
                    {
                        BuyPart();
                        return;
                    }
                    other.GetComponent<LobbyCharacter>().NewPartOpen(typePart);
                    Destroy(gameObject);
                }
            }
        }

        #endregion

        #region PartForReward

        public void ChangeRW()
        {
            if (!AdsManager.IsReadyReward)
            {
                lockRWPopup.SetActive(true);
                DOVirtual.DelayedCall(1f, () => lockRWPopup.SetActive(false));
                return;
            }

            lockRWPopup.SetActive(false);
            AdsManager.Instance.PartReward(this);
        }

        public void AddCount()
        {
            ammountRW++;
            counterRW.text = ammountRW + "/" + maxRW;
            if (ammountRW >= maxRW)
            {
                isRewardPart = false;
                SaveData();
                buttonReward.transform.DOScale(0, 0.5f).OnComplete(() => canvas.SetActive(false));
                LobbyCharacter lobbyCharacter = GameObject.FindObjectOfType<LobbyCharacter>();
                lobbyCharacter.NewPartOpen(typePart);
                Destroy(gameObject);
            }
        }

        private void CheckPartForReward()
        {
            if (!isRewardPart)
                return;

            canvas.SetActive(true);
            buttonReward.SetActive(true);
            buttonReward.transform.DOScale(buttonReward.transform.localScale, 0.5f);
            counterRW.text = ammountRW + "/" + maxRW;
        }

        #endregion

        #region PartForPrice

        public void BuyPart()
        {
            if(MoneyWallet.Instance.Money() >= price)
            {
                MoneyWallet.Instance.MoneyMinus(price);
                buttonPrice.transform.DOScale(0, 0.5f).OnComplete(() => canvas.SetActive(false));
                isMoneyPart = false;
                SaveData();
            }
        }

        private void CheckPartForPrice()
        {
            if (!isMoneyPart)
                return;

            canvas.SetActive(true);
            buttonPrice.SetActive(true);
            buttonPrice.transform.DOScale(buttonPrice.transform.localScale, 0.5f);
            counterMoney.text = price.ToString();
        }

        #endregion

        #region Load&SaveData

        private void LoadData()
        {
            ammountRW = ES3.Load("ammountRW" + idPart, ammountRW);
            isRewardPart = ES3.Load("isRewardPart" + idPart, isRewardPart);
            isMoneyPart = ES3.Load("isMoneyPart" + idPart, isMoneyPart);
        }

        private void SaveData()
        {
            ES3.Save("ammountRW" + idPart, ammountRW);
            ES3.Save("isRewardPart" + idPart, isRewardPart);
            ES3.Save("isMoneyPart" + idPart, isMoneyPart);
        }

        #endregion
    }
}
