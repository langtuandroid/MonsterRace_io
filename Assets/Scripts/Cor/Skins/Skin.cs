using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

namespace PlayKing.Cor
{
    public class Skin : MonoBehaviour
    {
        [Header("IdSkin")]
        [SerializeField] private string idSkin;

        [Header("FragmentsSkin")]
        [SerializeField] SkinnedMeshRenderer[] fragments;
        [SerializeField] Material mat;

        [Header("SliderProgress")]
        [SerializeField] Slider _slider;
        [SerializeField] private int ammountFramgents;

        [Header("PointSkin")]
        [SerializeField] Transform pointSkin;

        [Header("SkinEffeñå³")]
        [SerializeField] GameObject effect;

        [Header("SkinAnimation")]
        [SerializeField] DOTweenAnimation punchSkin;

        [Header("StatusSkin")]
        [SerializeField] private bool isOpenSkin;
        private bool isPartOpen;
        private bool isSetProgress;

        SkinsController _skinsController;

        public Transform Point()
        {
            return pointSkin;
        }

        private void Start()
        {
            LoadSave();
            CheckStatusSkin();
            _skinsController = GameObject.FindObjectOfType<SkinsController>();
        }

        public void ActiveFragmentsSkin()
        {
            if (isPartOpen)
                return;

            if (!isPartOpen)
            {
                punchSkin.DOPlay();
                fragments[ammountFramgents].material = mat;


                UIManager.Instance.SettingsButtonScreen(false);
                UIManager.Instance.MoneyScreen(false);
                UIManager.Instance.BonusScreen(false);
                UIManager.Instance.RewardScreen(true);
                
                SaveSkin();
                isPartOpen = true;
            }
        }

        public void UpdateSkin()
        {
            _slider.minValue = 0;
            _slider.maxValue = 4;
            if (!isSetProgress)
            {
                _slider.value = ammountFramgents;
                UIManager.Instance.BonusScreen(true);
                isSetProgress = true;
            }
            if (_slider.value < ammountFramgents + 1)
                _slider.value += 0.004f;

            if(!effect.activeSelf)
                effect.SetActive(true);
        }

        private void CheckStatusSkin()
        {
            if (isOpenSkin)
            {
                foreach(var i in fragments)
                {
                    i.material = mat;
                }
                return;
            }

            if (ammountFramgents > 0)
            {
                for (int i = 0; i < ammountFramgents; i++)
                {
                    fragments[i].material = mat;
                }
            }
        }

        public void OpenFramgentSkin()
        {
            ActiveFragmentsSkin();
            effect.SetActive(false);
            ammountFramgents++;
            if (ammountFramgents >= 4)
                isOpenSkin = true;

            if (ammountFramgents == 4)
            {
                isOpenSkin = true;
                _skinsController.NewProgressSkin();
            }

            SaveSkin();
        }

        public void CloseSkin()
        {
            isOpenSkin = false;
            ammountFramgents = 0;
            SaveSkin();
        }

        #region Load&Save

        private void LoadSave()
        {
            ammountFramgents = ES3.Load("ammountFramgents" + idSkin, ammountFramgents);
            isOpenSkin = ES3.Load("isOpenSkin" + idSkin, isOpenSkin);
        }

        private void SaveSkin()
        {
            ES3.Save("ammountFramgents" + idSkin, ammountFramgents);
            ES3.Save("isOpenSkin" + idSkin, isOpenSkin);
        }

        #endregion
    }
}
