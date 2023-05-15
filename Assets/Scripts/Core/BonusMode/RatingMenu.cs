using UnityEngine;
using DG.Tweening;
using UnityEngine.Serialization;

namespace Core
{
    public class RatingMenu : MonoBehaviour
    {
        #region Variables

        [Header("MenuScreens")]
        [SerializeField] private RatingScreen ratingScreen;
        [SerializeField] private AnonserTutorialScreen anonserTutorial;
        [SerializeField] private AnonserScreen screenReward;
        [SerializeField] private AnonserScreen screenSkinReward;

        [Space]
        [Header("SkinTitle")]
        [SerializeField] private GameObject skinTitle;
        [SerializeField] private Transform targetSkin;

        [FormerlySerializedAs("_ratingLeaderboard")]
        [Space]
        [Header("RatingLedearboard")]
        [SerializeField] private RatingLeaderboard ratingLeaderboard;

        private bool _isFirtsOpen;

        #endregion
      
        private void Start()
        {
            LoadData();
            if (!_isFirtsOpen)
            {
                anonserTutorial.ActiveScreen();
                _isFirtsOpen = true;
                SaveData();
                return;
            }

            skinTitle.transform.parent = targetSkin.parent;
            skinTitle.transform.position = targetSkin.position;
            skinTitle.transform.localScale = targetSkin.localScale;
        }

        public void Play()
        {
            ratingScreen.ActiveScreen();
        }

        public void FirstOpen()
        {
            DOVirtual.DelayedCall(0.8f, () => ratingLeaderboard.ScrollAnimation());
            DOVirtual.DelayedCall(4f, () => ratingScreen.ActiveScreen());
        }

        public void ChangeChestReward()
        {
            screenReward.ActiveScreen();
        }

        public void ChangeSkinReward()
        {
            screenSkinReward.ActiveScreen();
        }

        #region Load&SaveData

        private void LoadData()
        {
            _isFirtsOpen = ES3.Load("isFirtsOpen", _isFirtsOpen);
        }

        private void SaveData()
        {
            ES3.Save("isFirtsOpen", _isFirtsOpen);
        }

        #endregion
    }
}
