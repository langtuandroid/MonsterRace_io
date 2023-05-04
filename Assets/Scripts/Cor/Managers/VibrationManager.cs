using UnityEngine;
using MoreMountains.NiceVibrations;

namespace Cor
{
    public class VibrationManager : MonoBehaviour
    {
        #region Singelton

        public static VibrationManager Instance;

        private void Awake()
        {
            Instance = this;
        }

        #endregion

        [SerializeField] private bool isOffVibration;

        public bool ISOffVibration()
        {
            return isOffVibration;
        }

        private void Start()
        {
            LoadData();
        }

        public void VibrationOffAndOn(bool isActive)
        {
            isOffVibration = isActive;
            SaveData();
        }

        public void WeakVibration()
        {
            if (isOffVibration)
                return;

            MMVibrationManager.Haptic(HapticTypes.Selection, false, true, this);
        }

        public void LowVibration()
        {
            if (isOffVibration)
                return;

            MMVibrationManager.Haptic(HapticTypes.Success, false, true, this);
        }

        public void MediumVibration()
        {
            if (isOffVibration)
                return;


            MMVibrationManager.Haptic(HapticTypes.Failure, false, true, this);
        }

        public void HeavyVibration()
        {
            if (isOffVibration)
                return;

            MMVibrationManager.Haptic(HapticTypes.HeavyImpact, false, true, this);
        }

        #region Load&SaveData

        private void LoadData()
        {
            isOffVibration = ES3.Load("isOffVibration", isOffVibration);
        }

        private void SaveData()
        {
            ES3.Save("isOffVibration", isOffVibration);
        }

        #endregion
    }
}
