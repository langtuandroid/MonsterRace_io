using UnityEngine;

namespace Core
{
    public class Tutorial : MonoBehaviour
    {
        private bool _isCompletedTutorial;

        private void Start()
        {
            LoadSave();
            if (!_isCompletedTutorial)
            {
                UIManager.Instance.TutorialScreen(true);
            }
        }

        public void Complet()
        {
            if (_isCompletedTutorial)
                return;

            UIManager.Instance.TutorialScreen(false);
            _isCompletedTutorial = true;
            Save();
        }

        #region Load&Save

        private void Save()
        {
            ES3.Save("isCompletedTutorial", _isCompletedTutorial);
        }

        private void LoadSave()
        {
            _isCompletedTutorial = ES3.Load("isCompletedTutorial", _isCompletedTutorial);
        }

        #endregion
    }
}
