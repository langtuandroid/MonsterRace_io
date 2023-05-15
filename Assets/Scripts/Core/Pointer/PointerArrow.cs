using System.Collections;
using System.Net.NetworkInformation;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;

namespace Core
{
    public class PointerArrow : MonoBehaviour
    {
        #region Variables

        [SerializeField] private Image image;
        private bool _isShown;

        #endregion

        public void SetIconPosition(Vector3 position, Quaternion rotation)
        {
            transform.position = position;
            transform.rotation = rotation;
        }

        public void Show()
        {
            if (_isShown) return;
            _isShown = true;

            StopAllCoroutines();
            StartCoroutine(IE_ShowProcess());
        }

        public void Hide()
        {
            if (!_isShown) return;
            _isShown = false;

            StopAllCoroutines();
            StartCoroutine(IE_HideProcess());
        }

        private IEnumerator IE_ShowProcess()
        {
            image.enabled = true;
            transform.localScale = Vector3.zero;
            for (float t = 0; t < 1f; t += Time.deltaTime * 4f)
            {
                transform.localScale = Vector3.one * t;
                yield return null;
            }
            transform.localScale = Vector3.one;
        }

        private IEnumerator IE_HideProcess()
        {
            for (float t = 0; t < 1f; t += Time.deltaTime * 4f)
            {
                transform.localScale = Vector3.one * (1f - t);
                yield return null;
            }
            image.enabled = false;
        }
    }
}
