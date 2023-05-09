using UnityEngine;
using DG.Tweening;

namespace Cor
{
    public class RatingMenu : MonoBehaviour
    {
        #region Variables

        [Header("MenuScreens")]
        [SerializeField] RatingScreen ratingScreen;
        [SerializeField] AnonserTutorialScreen anonserTutorial;
        [SerializeField] AnonserScreen screenReward;
        [SerializeField] AnonserScreen screenSkinReward;

        [Space]
        [Header("SkinTitle")]
        [SerializeField] GameObject skinTitle;
        [SerializeField] Transform targetSkin;

        [Space]
        [Header("RatingLedearboard")]
        [SerializeField] RatingLeaderboard _ratingLeaderboard;

        private bool isFirtsOpen;

        #endregion

        private void Start()
        {
            LoadData();
            if (!isFirtsOpen)
            {
                anonserTutorial.ActiveScreen();
                isFirtsOpen = true;
                SaveData();
                return;
            }

            skinTitle.transform.parent = targetSkin.parent;
            skinTitle.transform.position = targetSkin.position;
            skinTitle.transform.localScale = targetSkin.localScale;
            ratingScreen.ActiveScreen();
        }

        public void FirstOpen()
        {
            DOVirtual.DelayedCall(0.8f, () => _ratingLeaderboard.ScrollAnimation());
            DOVirtual.DelayedCall(4f, () => ratingScreen.ActiveScreen());
        }

        #region Load&SaveData

        private void LoadData()
        {
            isFirtsOpen = ES3.Load("isFirtsOpen", isFirtsOpen);
        }

        private void SaveData()
        {
            ES3.Save("isFirtsOpen", isFirtsOpen);
        }

        #endregion
    }
}
