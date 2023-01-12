using UnityEngine;
using MoreMountains.NiceVibrations;

namespace PlayKing.Cor
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

        [Header("VibrationSettings")]
        [SerializeField] GameObject buttonOffVibration;
        [SerializeField] GameObject buttonOnVibration;
        private bool isOffVibration;

        public void VibrationOffAndOn(bool isActive)
        {
            isOffVibration = isActive;

            if (isActive)
            {
                if (buttonOffVibration != null)
                    buttonOffVibration.SetActive(false);
                if (buttonOnVibration != null)
                    buttonOnVibration.SetActive(true);
            }
            else
            {
                if (buttonOffVibration != null)
                    buttonOffVibration.SetActive(true);
                if (buttonOnVibration != null)
                    buttonOnVibration.SetActive(false);
            }
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
