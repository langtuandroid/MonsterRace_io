using UnityEngine;
using UnityEngine.UI;
using MoreMountains.NiceVibrations;

namespace BlueStellar.Cor
{
    public class VibrationController : MonoBehaviour
    {
        #region Singelton

        public static VibrationController Instance;

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

        public void SettingsActive(bool isActive)
        {
            UIManager.Instance.SettingsScreen(isActive);
        }

        public void VibrationOffAndOn(bool isActive)
        {
            isOffVibration = isActive;
        }

        public void UnstackVibration()
        {
            if (isOffVibration)
                return;

            MMVibrationManager.Haptic(HapticTypes.Success, false, true, this);
        }

        public void ClaimVibration()
        {
            if (isOffVibration)
                return;

            MMVibrationManager.Haptic(HapticTypes.Selection, false, true, this);
        }

        public void KnockVibration()
        {
            if (isOffVibration)
                return;

            MMVibrationManager.Haptic(HapticTypes.HeavyImpact, false, true, this);
        }

        public void AttackVibration()
        {
            if (isOffVibration)
                return;

            MMVibrationManager.Haptic(HapticTypes.Failure, false, true, this);
        }
    }
}
