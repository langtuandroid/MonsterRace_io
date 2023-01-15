using UnityEngine;

namespace PlayKing.Cor
{
    public class CameraController : MonoBehaviour
    {
        #region Singleton

        public static CameraController Instance;

        private void Awake()
        {
            Instance = this;    
        }

        #endregion

        [SerializeField] GameObject characterStateCam;
        [SerializeField] GameObject monsterStateCam;
        [SerializeField] GameObject finishCam;

        public void ChangeMonsterStateCam()
        {
            characterStateCam.SetActive(false);
            monsterStateCam.SetActive(true);
        }

        public void FinishCam()
        {
            characterStateCam.SetActive(false);
            monsterStateCam.SetActive(false);
            finishCam.SetActive(true);
        }
    }
}
