using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

namespace PlayKing.Cor
{
    public class Skin : MonoBehaviour
    {
        [SerializeField] private string idSkin;
        [SerializeField] GameObject[] fragments;
        [SerializeField] Material mat;
        [SerializeField] Slider _slider;
        [SerializeField] private int ammountFramgents;
        [SerializeField] private bool isOpenSkin;
        [SerializeField] ParticleSystem effect;

        private void Start()
        {
            Load();
        }

        public void ChangeSkin()
        {
            _slider.minValue = 0;
            _slider.maxValue = 4;
            _slider.value = ammountFramgents;

            fragments[0].GetComponent<SkinnedMeshRenderer>().material = mat;
            gameObject.GetComponent<DOTweenAnimation>().DOPlay();
        }

        public void UpdateSkin(bool isU)
        {
            effect.Play();
        }

        public void OpenFramgentSkin()
        {
            ammountFramgents++;
            if(ammountFramgents >= 4)
            {
                isOpenSkin = true;
            }
        }

        #region Load&Save

        private void Load()
        {
            ammountFramgents = ES3.Load("ammountFramgents" + idSkin, ammountFramgents);
            isOpenSkin = ES3.Load("isOpenSkin" + idSkin, isOpenSkin);
        }

        private void Save()
        {
            ES3.Save("ammountFramgents" + idSkin, ammountFramgents);
            ES3.Save("isOpenSkin" + idSkin, isOpenSkin);
        }

        #endregion
    }
}
