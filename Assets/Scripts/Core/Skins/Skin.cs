using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

namespace Core
{
    public class Skin : MonoBehaviour
    {
        #region Variables

        [Header("IdSkin")]
        [SerializeField] private string idSkin;

        [Space]
        [Header("Buttons")]
        [SerializeField] GameObject next;
        [SerializeField] GameObject claim;

        [Space]
        [Header("FragmentsSkin")]
        [SerializeField] SkinnedMeshRenderer[] fragments;
        [SerializeField] Material mat;
        [SerializeField] string[] ids;

        [Space]
        [Header("SliderProgress")]
        [SerializeField] Slider _slider;
        [SerializeField] Text textProgress;
        [SerializeField] Image img;
        [SerializeField] Sprite headImg;
        [SerializeField] private int ammountFramgents;
        private int setProgress;
        private int progress;

        [Space]
        [Header("PointSkin")]
        [SerializeField] Transform pointSkin;

        [Space]
        [Header("SkinEffeсеt")]
        [SerializeField] GameObject effect;

        [Space]
        [Header("SkinAnimation")]
        [SerializeField] DOTweenAnimation punchSkin;

        [Space]
        [Header("StatusSkin")]
        [SerializeField] private bool isOpenSkin;
        private bool isPartOpen;
        private bool isSetProgress;

        [Space]
        [SerializeField] SkinsController _skinsController;
        [SerializeField] PartsSkinSaver _partsSkinSaver;

        #endregion

        public Transform Point()
        {
            return pointSkin;
        }

        private void Start()
        {
            LoadSave();
            CheckStatusSkin();
        }

        private void ActiveFragmentsSkin()
        {
            if (isPartOpen) 
                return;
            
            isPartOpen = true;
            punchSkin.DOPlay();
            fragments[ammountFramgents].material = mat;
            UIManager.Instance.MoneyScreen(false);
            SaveSkin();
        }

        public void UpdateSkin()
        {
            _slider.minValue = 0;
            _slider.maxValue = 100;
            img.sprite = headImg;

            if (!isSetProgress)
            {
                progress = ammountFramgents switch
                {
                    0 => 0,
                    1 => 25,
                    2 => 50,
                    3 => 75,
                    4 => 100,
                    _ => progress
                };
                setProgress = progress;
                _slider.value = progress;
                textProgress.text = progress + "%";
                isSetProgress = true;
                UIManager.Instance.BonusScreen(true);
            }

            if (_slider.value < setProgress + 25)
                _slider.value += 0.1f;

            if (_slider.value < 10)
            {
                textProgress.text = _slider.value.ToString().Substring(0, 1) + "%";
            }

            if (_slider.value >= 10) 
            { 
                textProgress.text = _slider.value.ToString().Substring(0, 2) + "%";
            }

            if (_slider.value >= 100)
            {
                textProgress.text = _slider.value.ToString().Substring(0, 3) + "%";
            }

            if (!effect.activeSelf)
                effect.SetActive(true);
        }

        public void AddSkinPart()
        {
            LoadSave();
            _partsSkinSaver.AddNewID(ids[ammountFramgents]);
        }

        public void OpenFramgentSkin()
        {
            LoadSave();

            ActiveFragmentsSkin();
            effect.SetActive(false);
            ammountFramgents++;
            next.SetActive(true);

            if (ammountFramgents >= 4)
                isOpenSkin = true;

            if (ammountFramgents == 4)
            {
                next.SetActive(false);
                claim.SetActive(true);
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

        private void CheckStatusSkin()
        {
            if (isOpenSkin)
            {
                foreach (var i in fragments)
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
