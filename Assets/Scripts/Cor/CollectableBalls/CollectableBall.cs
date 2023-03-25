using System.Collections;
using UnityEngine;
using DG.Tweening;

namespace BlueStellar.Cor
{
    public class CollectableBall : MonoBehaviour
    {
        #region Variables

        [Header("BallsSettings")]
        [SerializeField] Color colorBall;
        [SerializeField] Color colorClaim;
        [SerializeField] Color neutral;
        [SerializeField] Color[] colors;
        [SerializeField] MeshRenderer meshRenderer;
        [SerializeField] Rigidbody _rb;
        private bool isBallDestroyed;
        public bool cantStack;

        [Header("BallType")]
        [SerializeField] CharacterColorType _ballType;

        CharacterColorType newType;
        CollectableBallsField _collectableBallsField;

        #endregion

        public CharacterColorType Type()
        {
            return _ballType;
        }

        private void Start()
        {
            _collectableBallsField = GameObject.FindObjectOfType<CollectableBallsField>();
        }

        public bool IsTrueCharacter(CharacterColorType characterColorType)
        {
            if (cantStack)
                return false;

            if (_ballType == characterColorType ||
                _ballType == CharacterColorType.Neutral)
            {
                newType = characterColorType;
                SwitchColor(characterColorType);
                return true;
            }

            return false;
        }

        public void BallInStack()
        {
            cantStack = true;
            if(_rb != null) _rb.isKinematic = true;

            if(_collectableBallsField != null)
                _collectableBallsField.RemoveBall(this);
        }

        public void ColorAnimation()
        {
            meshRenderer.material.DOColor(colorClaim, 0.2f);
            StopAllCoroutines();
            StartCoroutine(IE_ReturnColorBall());
        }
       
        public void BallNeutral()
        {
            cantStack = true;
            transform.SetParent(null);
            gameObject.GetComponent<Collider>().isTrigger = false;
            meshRenderer.material.DOColor(neutral, 0.2f);
            if(_rb == null){
                _rb = gameObject.AddComponent<Rigidbody>();
            }
            _rb.isKinematic = false;
            _rb.AddForce(new Vector3(0f, 6f, -1f), ForceMode.Impulse);
            _ballType = CharacterColorType.Neutral;
        }

        public void Normal()
        {
            _ballType = CharacterColorType.Neutral;
            gameObject.GetComponent<Collider>().isTrigger = true;
            if(_rb != null)_rb.isKinematic = true;
            cantStack = false;
        }

        public void BallToMonster(CollectableMonster ballsMonster)
        {
            if (!isBallDestroyed)
            {
                ballsMonster.BallActiveted(_ballType);
                isBallDestroyed = true;
                Invoke("Deactive", 0.3f);
            }
        }

        private IEnumerator IE_ReturnColorBall()
        {
            yield return new WaitForSeconds(0.2f);

            meshRenderer.material.DOColor(colorBall, 0.2f);
            _ballType = newType;
        }

        private void SwitchColor(CharacterColorType _characterColorType)
        {
            switch (_characterColorType)
            {
                case CharacterColorType.Blue:
                    colorBall = colors[0];
                    break;
                case CharacterColorType.Green:
                    colorBall = colors[1];
                    break;
                case CharacterColorType.Violet:
                    colorBall = colors[2];
                    break;
                case CharacterColorType.Yellow:
                    colorBall = colors[3];
                    break;
                case CharacterColorType.Red:
                    colorBall = colors[4];
                    break;
                case CharacterColorType.Purple:
                    colorBall = colors[5];
                    break;
            }
        }

        private void Deactive()
        {
            gameObject.SetActive(false);
        }
    }
}
