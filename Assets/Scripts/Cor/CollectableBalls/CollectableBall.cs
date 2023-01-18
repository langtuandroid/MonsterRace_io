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
        [SerializeField] CharacterColorType _ballType;

        [Header("Trail")]
        [SerializeField] GameObject trail;

        CollectableBallsField _collectableBallsField;
        Rigidbody _rb;

        public CharacterColorType Type()
        {
            return _ballType;
        }

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

            if (_ballType == characterColorType ||
                _ballType == CharacterColorType.Neutral)
            {
                ch = characterColorType;
                SwitchColor(characterColorType);
                return true;
            }

            return false;
        }

        CharacterColorType ch;

        public void BallInStack()
        {
            cantStack = true;
            _rb.isKinematic = true;
            meshRenderer.material.DOColor(colorClaim, 0.2f);
            _collectableBallsField.RemoveBall(this);
          
            StartCoroutine(IE_ReturnColorBall());
            StartCoroutine(IE_CloseTrail());
        }
       
        public void BallNeutral()
        {
            cantStack = true;
            transform.SetParent(null);
            gameObject.GetComponent<Collider>().isTrigger = false;
            meshRenderer.material.DOColor(neutral, 0.2f);
            _rb.isKinematic = false;
            _rb.AddForce(new Vector3(0f, 9f, -2f), ForceMode.Impulse);
            _ballType = CharacterColorType.Neutral;
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

        public void Normal()
        {
            _ballType = CharacterColorType.Neutral;
            gameObject.GetComponent<Collider>().isTrigger = true;
            _rb.isKinematic = true;
            cantStack = false;
        }

        public IEnumerator IE_BallToMonster(BallsMonster ballsMonster)
        {
            yield return new WaitForSeconds(0.35f);

            if (trail != null)
                trail.SetActive(false);

            if (!isBallDestroyed)
            {
                ballsMonster.BallActiveted(_ballType);
                isBallDestroyed = true;
                Destroy(gameObject, 0.1f);
            }
        }

        private IEnumerator IE_ReturnColorBall()
        {
            yield return new WaitForSeconds(0.2f);

            meshRenderer.material.DOColor(colorBall, 0.2f);
            _ballType = ch;
        }

        private IEnumerator IE_CloseTrail()
        {
            yield return new WaitForSeconds(0.4f);

            if(trail != null)
            {
                trail.SetActive(false);
            }
        }
    }
}
