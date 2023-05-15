using System.Collections;
using UnityEngine;

namespace Core
{
    public class TutorialPopup : MonoBehaviour
    {
        #region Variables

        [SerializeField] GameObject[] popups;
        private bool isClosedPopups;

        #endregion

        private void Start()
        {
            Load();
            if (!isClosedPopups)
            {
                if (LevelManager.Instance.GetLvlNumber() > 1)
                {
                    isClosedPopups = true;
                    Save();
                    return;
                }

                popups[0].SetActive(true);
                StartCoroutine(IE_ClosePopup(0));
            }
        }

        public void NextPopupActive()
        {
            if (isClosedPopups)
                return;

            popups[1].SetActive(true);
            StartCoroutine(IE_ClosePopup(1));
        }

        private IEnumerator IE_ClosePopup(int index)
        {
            yield return new WaitForSeconds(3f);

            popups[index].SetActive(false);
        }

        #region Load&Save

        private void Load()
        {
            isClosedPopups = ES3.Load("isClosedPopups", isClosedPopups);
        }

        private void Save()
        {
            ES3.Load("isClosedPopups", isClosedPopups);
        }

        #endregion
    }
}
