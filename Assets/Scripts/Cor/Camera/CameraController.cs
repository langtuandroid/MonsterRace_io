using UnityEngine;
using Cinemachine;

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
        [SerializeField] ParticleSystem effect;

        Transform player;

        private void Start()
        {
            player = GameObject.FindObjectOfType<PlayerMovement>().transform;
            characterStateCam.GetComponent<CinemachineVirtualCamera>().Follow = player;
            characterStateCam.GetComponent<CinemachineVirtualCamera>().LookAt = player;
            monsterStateCam.GetComponent<CinemachineVirtualCamera>().Follow = player;
            monsterStateCam.GetComponent<CinemachineVirtualCamera>().LookAt = player;
            finishCam.GetComponent<CinemachineVirtualCamera>().Follow = player;
            finishCam.GetComponent<CinemachineVirtualCamera>().LookAt = player;
        }

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
            Invoke("R", 0.8f);
        }

        private void R()
        {
            effect.Play();
        }
    }
}
