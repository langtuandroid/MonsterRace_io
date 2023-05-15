using UnityEngine;
using Cinemachine;

namespace Core
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

        #region Variables

        [SerializeField] private CinemachineVirtualCamera characterStateCam;
        [SerializeField] private CinemachineVirtualCamera monsterStateCam;
        [SerializeField] private CinemachineVirtualCamera jumpStateCam;
        [SerializeField] private CinemachineVirtualCamera finishCam;
        [SerializeField] private CinemachineVirtualCamera skinCam;

        private Transform _player;

        #endregion

        private void Start() =>  SetTargetCameras();
     
        public void CharacterCam(bool isActive) => characterStateCam.gameObject.SetActive(isActive);

        public void ChangeMonsterCam(bool isActive) => monsterStateCam.gameObject.SetActive(isActive);

        public void JumpStateCam(bool isActive) => jumpStateCam.gameObject.SetActive(isActive);

        public void SkinCam(Transform targetSkin, bool isActive)
        {
            skinCam.Follow = targetSkin;
            skinCam.LookAt = targetSkin;
            skinCam.gameObject.SetActive(isActive);
        }

        private void SetTargetCameras()
        {
            _player = FindObjectOfType<PlayerMovement>().transform;
            characterStateCam.Follow = _player;
            characterStateCam.LookAt = _player;
            monsterStateCam.Follow = _player;
            monsterStateCam.LookAt = _player;
            jumpStateCam.Follow = _player;
            jumpStateCam.LookAt = _player;
            finishCam.Follow = _player;
            finishCam.LookAt = _player;
        }
    }
}
