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

        public void ChangeMonsterStateCam()
        {
            characterStateCam.SetActive(false);
            monsterStateCam.SetActive(true);
        }
    }
}
