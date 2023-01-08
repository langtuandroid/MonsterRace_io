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
        [SerializeField] MeshRenderer meshRenderer;

        [Header("NeedCharacterType")]
        [SerializeField] CharacterColorType _characterColorType;

        CollectableBallsField _collectableBallsField;

        private void Start()
        {
            _collectableBallsField = GameObject.FindObjectOfType<CollectableBallsField>();
            transform.DOScale(transform.localScale, 0.5f).From(0);
        }

        public bool IsTrueCharacter(CharacterColorType characterColorType)
        {
            if (_characterColorType == characterColorType)
                return true;

            return false;
        }

        public void BallInStack()
        {
            meshRenderer.material.DOColor(colorClaim, 0.2f);
            _collectableBallsField.RemoveBall(this);
            StartCoroutine(IE_ReturnColorBall());
        }

        public IEnumerator IE_BallToMonster(BallsMonster ballsMonster)
        {
            yield return new WaitForSeconds(0.7f);

            Destroy(gameObject);
        }

        private IEnumerator IE_ReturnColorBall()
        {
            yield return new WaitForSeconds(0.15f);

            meshRenderer.material.DOColor(colorBall, 0.2f);
        }
    }
}
