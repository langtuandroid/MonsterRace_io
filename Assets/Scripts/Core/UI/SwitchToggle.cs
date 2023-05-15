using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

namespace Core
{
    public class SwitchToggle : MonoBehaviour
    {
        #region Variables

        [SerializeField] private RectTransform uiHandleRectTransform;
        [SerializeField] private Image bgImg;
        [SerializeField] private Image handleImg;
        [SerializeField] private Sprite onBg;
        [SerializeField] private Sprite onImg;
        [SerializeField] private Sprite offBg;
        [SerializeField] private Sprite offImg;
        [SerializeField] private Toggle toggle;
        [SerializeField] private VibrationManager vibrationController;

        private Vector2 handlePosition;

        #endregion

        private void Start()
        {
            handlePosition = uiHandleRectTransform.anchoredPosition;

            toggle.onValueChanged.AddListener(OnSwitch);

            if (!vibrationController.IsOffVibration())
                toggle.isOn = true;
            if (toggle.isOn)
                OnSwitch(true);
        }

        private void OnSwitch(bool on)
        {
            uiHandleRectTransform.DOAnchorPos(on ? handlePosition * -0.1f : handlePosition, .4f).SetEase(Ease.InOutBack);

            if (on)
            {
                bgImg.sprite = onBg;
                handleImg.sprite = onImg;
                vibrationController.VibrationOffAndOn(false);
                return;
            }

            bgImg.sprite = offBg;
            handleImg.sprite = offImg;
            vibrationController.VibrationOffAndOn(true);
        }
    }
}
