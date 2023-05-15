using UnityEngine;
using MoreMountains.NiceVibrations;

namespace Core
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

        private bool _isOffVibration;

        public bool IsOffVibration()
        {
            return _isOffVibration;
        }

        private void Start()
        {
            LoadData();
        }

        public void VibrationOffAndOn(bool isActive)
        {
            _isOffVibration = isActive;
            SaveData();
        }

        public void WeakVibration()
        {
            if (_isOffVibration)
                return;

            MMVibrationManager.Haptic(HapticTypes.Selection, false, true, this);
        }

        public void LowVibration()
        {
            if (_isOffVibration)
                return;

            MMVibrationManager.Haptic(HapticTypes.Success, false, true, this);
        }

        public void MediumVibration()
        {
            if (_isOffVibration)
                return;


            MMVibrationManager.Haptic(HapticTypes.Failure, false, true, this);
        }

        public void HeavyVibration()
        {
            if (_isOffVibration)
                return;

            MMVibrationManager.Haptic(HapticTypes.HeavyImpact, false, true, this);
        }

        #region Load&SaveData

        private void LoadData()
        {
            _isOffVibration = ES3.Load("isOffVibration", _isOffVibration);
        }

        private void SaveData()
        {
            ES3.Save("isOffVibration", _isOffVibration);
        }

        #endregion
    }
}
