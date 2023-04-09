using UnityEngine;

namespace Cor
{
    public class Tutorial : MonoBehaviour
    {
        private bool isCompletedTutorial;

        private void Start()
        {
            LoadSave();
            if (!isCompletedTutorial)
            {
                UIManager.Instance.TutorialScreen(true);
            }
        }

        public void Complet()
        {
            if (isCompletedTutorial)
                return;

            UIManager.Instance.TutorialScreen(false);
            isCompletedTutorial = true;
            Save();
        }

        #region Load&Save

        private void Save()
        {
            ES3.Save("isCompletedTutorial", isCompletedTutorial);
        }

        private void LoadSave()
        {
            isCompletedTutorial = ES3.Load("isCompletedTutorial", isCompletedTutorial);
        }

        #endregion
    }
}
