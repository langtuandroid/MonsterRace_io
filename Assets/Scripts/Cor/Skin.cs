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
        [SerializeField] GameObject[] fragments;
        [SerializeField] Material mat;

        [Header("SliderProgress")]
        [SerializeField] Slider _slider;
        [SerializeField] private int ammountFramgents;

        [Header("SkinEffeñå³")]
        [SerializeField] ParticleSystem effect;

        [Header("StatusSkin")]
        [SerializeField] private bool isOpenSkin;

        private void Start()
        {
            LoadSave();
        }

        public void ChangeSkin()
        {
            fragments[ammountFramgents].SetActive(true);
            ammountFramgents++;
            gameObject.GetComponent<DOTweenAnimation>().DOPlay();
        }

        public void UpdateSkin()
        {
            _slider.minValue = 0;
            _slider.maxValue = 4;
            _slider.value = ammountFramgents;
            if (_slider.value < ammountFramgents + 1)
                _slider.value += 0.003f;
            effect.Play();
        }

        public void OpenFramgentSkin()
        {
            ammountFramgents++;
            if (ammountFramgents >= 4)
                isOpenSkin = true;
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
