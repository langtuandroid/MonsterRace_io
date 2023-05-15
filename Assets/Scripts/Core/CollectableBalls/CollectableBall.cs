using UnityEngine;
using DG.Tweening;
using Core.MyPool;
using UnityEngine.Serialization;

namespace Core
{
    public class CollectableBall : MonoBehaviour
    {
        #region Variables

        [Header("BallsSettings")]
        [SerializeField] private Color colorBall;
        [SerializeField] private Color colorClaim;
        [SerializeField] private Color neutral;
        [SerializeField] private Color[] colors;
        [SerializeField] private MeshRenderer meshRenderer;
        [SerializeField] private GameObject[] balls;
        [SerializeField] private Rigidbody rb;
        [SerializeField] private Collider _collider;

        [FormerlySerializedAs("_ballType")]
        [Header("BallType")]
        [SerializeField] private CharacterColorType ballType;
        [SerializeField] private CharacterColorType savedType;

        private bool _isBallDestroyed;
        private bool _cantStack;
        
        private CollectableBallsField _collectableBallsField;

        #endregion

        public CharacterColorType Type()
        {
            return ballType;
        }

        public bool IsTrueCharacter(CharacterColorType characterColorType)
        {
            if (_cantStack)
                return false;

            if (ballType == characterColorType ||
                ballType == CharacterColorType.Neutral)
            {
                SwitchColor(characterColorType);
                return true;
            }

            return false;
        }

        private void OnEnable()
        {
            SetupBall();
        }

        private void Start()
        {
            _collectableBallsField = FindObjectOfType<CollectableBallsField>();
        }
        
        public void BallInStack()
        {
            _cantStack = true;
            if(rb != null) rb.isKinematic = true;

            if(_collectableBallsField != null)
                _collectableBallsField.RemoveBall(this);
        }

        public void ColorAnimation()
        {
            meshRenderer.material.DOColor(colorClaim, 0.2f);
            DOVirtual.DelayedCall(0.15f, () => 
                meshRenderer.material.DOColor(colorBall, 0.2f));
        }
       
        public void BallNeutral()
        {
            _cantStack = true;
            transform.SetParent(null);
            _collider.isTrigger = false;
            meshRenderer.material.DOColor(neutral, 0.2f);
            if(rb == null) 
                rb = gameObject.AddComponent<Rigidbody>();
            rb.isKinematic = false;
            rb.AddForce(new Vector3(0f, 6f, -1f), ForceMode.Impulse);
            ballType = CharacterColorType.Neutral;
        }

        public void Normal()
        {
            ballType = CharacterColorType.Neutral;
            _collider.isTrigger = true;
            if(rb != null)rb.isKinematic = true;
            _cantStack = false;
        }

        public void BallToMonster(CollectableMonster ballsMonster)
        {
            if (!_isBallDestroyed)
            {
                ballsMonster.BallActiveted(ballType);
                _isBallDestroyed = true;
                NightPool.Despawn(gameObject, 0.2f);
            }
        }

        private void SetupBall()
        {
            _cantStack = false;
            ballType = savedType;
            SwitchColor(ballType);

            if (ballType == CharacterColorType.Blue)
            {
                if (BallSkins.Instance.IsBonusSkin())
                {
                    meshRenderer.enabled = false;
                    balls[BallSkins.Instance.GetIndex()].SetActive(true);
                    return;
                }
            }
            
            meshRenderer.material.color = colorBall;
        }

        
        private void SwitchColor(CharacterColorType characterColorType)
        {
            switch (characterColorType)
            {
                case CharacterColorType.Blue:
                    colorBall = BallSkins.Instance.GetColorSkin();
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
