using System.Collections;
using UnityEngine;
using DG.Tweening;

namespace PlayKing.Cor
{
    public class CollectableBall : MonoBehaviour
    {
        [Header("BallsSettings")]
        [SerializeField] Color colorBall;
        [SerializeField] Color colorClaim;
        [SerializeField] Color neutral;
        [SerializeField] Color[] colors;
        [SerializeField] MeshRenderer meshRenderer;
        private bool isBallDestroyed;
        public bool cantStack;

        [Header("NeedCharacterType")]
        [SerializeField] CharacterColorType _characterColorType;

        CollectableBallsField _collectableBallsField;
        Rigidbody _rb;

        private void Start()
        {
            _collectableBallsField = GameObject.FindObjectOfType<CollectableBallsField>();
            _rb = GetComponent<Rigidbody>();
            transform.DOScale(transform.localScale, 0.2f).From(0);
        }

        public bool IsTrueCharacter(CharacterColorType characterColorType)
        {
            if (cantStack)
                return false;

            if (_characterColorType == characterColorType ||
                _characterColorType == CharacterColorType.Neutral)
            {
                SwitchColor(characterColorType);
                return true;
            }

            return false;
        }

        public void BallInStack()
        {
            cantStack = true;
            _rb.isKinematic = true;
            meshRenderer.material.DOColor(colorClaim, 0.2f);
            _collectableBallsField.RemoveBall(this);
            StartCoroutine(IE_ReturnColorBall());
        }
       
        public void BallNeutral()
        { 
            transform.SetParent(null);
            gameObject.GetComponent<Collider>().isTrigger = false;
            meshRenderer.material.DOColor(neutral, 0.2f);
            _rb.isKinematic = false;
            _rb.AddForce(new Vector3(0f, 9f, -2f), ForceMode.Impulse);
            _characterColorType = CharacterColorType.Neutral;
            cantStack = true;
            StartCoroutine(IE_Normal());
        }

        private IEnumerator IE_Normal()
        {
            yield return new WaitForSeconds(2.5f);

            gameObject.GetComponent<Collider>().isTrigger = true;
            _rb.isKinematic = true;
            cantStack = false;
        }

        public IEnumerator IE_BallToMonster(BallsMonster ballsMonster)
        {
            yield return new WaitForSeconds(0.35f);

            if (!isBallDestroyed)
            {
                ballsMonster.BallActiveted();
                isBallDestroyed = true;
                Destroy(gameObject, 0.1f);
            }
        }

        private IEnumerator IE_ReturnColorBall()
        {
            yield return new WaitForSeconds(0.15f);

            meshRenderer.material.DOColor(colorBall, 0.2f);
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
    }
}
