using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

namespace BlueStellar.Cor
{
    public class SkinPart : MonoBehaviour
    {
        #region Variables

        [SerializeField] private string idPart;
        [SerializeField] CharacterMonsterType typePart;
        [SerializeField] Transform point;
        [SerializeField] private float speedRotate;
        [SerializeField] private float maxSpeedRotate;
        [SerializeField] private bool isCharacterContact;
        [SerializeField] private bool isUp;

        Vector3 positionOffset;
        Vector3 startPos;

        Camera _camera;

        #endregion

        public string GetIDPart()
        {
            return idPart;
        }

        public CharacterMonsterType GetPartType()
        {
            return typePart;
        }

        private void Start()
        {
            _camera = Camera.main;
            startPos = transform.position;
        }

        private void Update()
        {
            point.transform.Rotate(0f, speedRotate, 0f);
        }

        #region PartMovement

        private Vector3 GetMousePosition()
        {
            return _camera.WorldToScreenPoint(transform.position);
        }

        private void OnMouseDown()
        {
            speedRotate = 0f;
            positionOffset = Input.mousePosition - GetMousePosition();
            isUp = false;
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
            isUp = true;
            transform.DOMove(startPos, 0.5f).OnComplete(() => speedRotate = maxSpeedRotate);
        }

        #endregion

        #region PartCollision

        private void OnTriggerStay(Collider other)
        {
            if (other.CompareTag("Character"))
            {
                isCharacterContact = true;
                if (isUp)
                {
                    other.GetComponent<LobbyCharacter>().NewPartOpen(typePart);
                    Destroy(gameObject);
                }
            }
        }

        private void OnTriggerExit(Collider other)
        {
            isCharacterContact = false;
        }

        #endregion
    }
}
