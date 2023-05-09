using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

namespace Cor
{
    public class RatingMember : MonoBehaviour
    {
        #region Variables

        [Header("IDMember")]
        [SerializeField] private string id;

        [Space]
        [Header("RatinNumber")]
        [SerializeField] GameObject[] ratingImg;
        [SerializeField] Text textRating;
        [SerializeField] private int numberRating;

        [Space]
        [Header("SmashesMember")]
        [SerializeField] Text textSmashes;
        [SerializeField] private int ammountSmashes;

        [Space]
        [Header("PlayerMember")]
        [SerializeField] private bool isPlayerMember;

        #endregion

        #region GetVariablesMember

        public int GetSmashes()
        {
            return ammountSmashes;
        }

        public bool IsPlayerMemeber()
        {
            return isPlayerMember;
        }

        #endregion

        public void SetupMemberSmashes()
        {
            LoadData();
            ChangeText();
        }

        public void SetNumberRating(int number)
        {
            numberRating = number;
            foreach (var i in ratingImg) i.SetActive(false);
            if (numberRating <= 3)
                ratingImg[numberRating - 1].SetActive(true);

            ChangeText();
        }

        public void AddSmashes(int ammount)
        {
            ammountSmashes += ammount;
            ChangeText();
            SaveData();
        }

        public void AnimationMember(Transform pos)
        {
            transform.DOScale(1.05f, 0.5f);
            transform.DOMoveY(pos.position.y, 0.8f).SetDelay(0.7f).OnComplete(() => transform.DOScale(1f, 0.5f));
        }

        private void ChangeText()
        {
            textRating.text = numberRating.ToString();
            textSmashes.text = ammountSmashes.ToString();
        }

        #region Load&SaveData

        private void LoadData()
        {
            ammountSmashes = ES3.Load("ammountSmashes" + id, ammountSmashes);
        }

        private void SaveData()
        {
            ES3.Save("ammountSmashes" + id, ammountSmashes);
        }

        #endregion
    }
}
