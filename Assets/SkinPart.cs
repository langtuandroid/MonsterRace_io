using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

namespace BlueStellar.Cor
{
    public class SkinPart : MonoBehaviour
    {
        [SerializeField] Vector3 positionOffset;
        [SerializeField] Vector3 startPos;
        Camera _camera;

        private void Start()
        {
            startPos = transform.position;
            _camera = Camera.main;
        }

        private Vector3 GetMousePosition()
        {
            return _camera.WorldToScreenPoint(transform.position);
        }

        private void OnMouseDown()
        {
            positionOffset = Input.mousePosition - GetMousePosition();
            //transform.DOMove(transform.position + 1f, 0.5f);
        }

        private void OnMouseDrag()
        {
            Vector3 dragPos = transform.position;
            dragPos.x = _camera.ScreenToWorldPoint(Input.mousePosition - positionOffset).x;
            dragPos.y = _camera.ScreenToWorldPoint(Input.mousePosition - positionOffset).y;
            dragPos.z = _camera.ScreenToWorldPoint(Input.mousePosition - positionOffset).z;
            transform.position = dragPos;
        }

        private void OnMouseUp()
        {
            transform.position = startPos;
        }
    }
}
