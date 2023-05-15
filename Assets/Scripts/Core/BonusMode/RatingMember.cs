using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
using UnityEngine.Serialization;

namespace Core
{
    public class RatingMember : MonoBehaviour
    {
        #region Variables

        [Header("IDMember")]
        [SerializeField] private string id;

        [Space]
        [Header("RatingNumber")]
        [SerializeField] private GameObject[] ratingImg;
        [SerializeField] private Text _textRating;
        [SerializeField] private int numberRating;

        [Space]
        [Header("SmashesMember")]
        [SerializeField] private Text _textSmashes;
        [FormerlySerializedAs("ammountSmashes")] [SerializeField] private int countSmashes;

        [Space]
        [Header("PlayerMember")]
        [SerializeField] private bool isPlayerMember;

        #endregion

        #region GetVariablesMember

        public int GetSmashes()
        {
            return countSmashes;
        }

        public int GetRating()
        {
            return numberRating;
        }

        public bool IsPlayerMember()
        {
            return isPlayerMember;
        }

        #endregion

        public void SetupMemberSmashes()
        {
            LoadData();
            ChangeText();
        }

        public void SetupMemberRating()
        {
            LoadData();
            SetNumberRating(numberRating);
        }

        public void SetNumberRating(int number)
        {
            numberRating = number;
            foreach (var i in ratingImg) i.SetActive(false);
            if (numberRating <= 3)
                ratingImg[numberRating - 1].SetActive(true);

            ChangeText();
            SaveData();
        }

        public void AddSmashes(int ammount)
        {
            countSmashes += ammount;
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
            _textRating.text = numberRating.ToString();
            _textSmashes.text = countSmashes.ToString();
        }

        #region Load&SaveData

        private void LoadData()
        {
            countSmashes = ES3.Load("ammountSmashes" + id, countSmashes);
            numberRating = ES3.Load("numberRating" + id, numberRating);
        }

        private void SaveData()
        {
            ES3.Save("ammountSmashes" + id, countSmashes);
            ES3.Save("numberRating" + id, numberRating);
        }

        #endregion
    }
}
