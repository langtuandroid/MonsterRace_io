using UnityEngine;
using TMPro;
using DG.Tweening;

namespace BlueStellar.Cor
{
    public class Gates : MonoBehaviour
    {
        [SerializeField] GatesType _gatesType;
        [SerializeField] TextMeshProUGUI textGates;
        [SerializeField] private int numberGates;
        [SerializeField] CollectableBall[] collectableBalls;
        private string symbolGate;

        public void SetGatesSettings(GatesType gatesType)
        {
            transform.DOScale(transform.localScale, 0.5f).From(0);
            _gatesType = gatesType;
            SwitchGatesText();
        }

        public void ActivetedBonus(StackBalls stackBalls)
        {
            for (int i = 0; i < numberGates; i++)
            {
                GameObject ball = Instantiate(collectableBalls[0].gameObject, transform.position, transform.rotation);
                stackBalls.AddCollectableBall(ball.GetComponent<CollectableBall>());
            }
            transform.DOScale(0, 0.5f).OnComplete(() => Destroy(gameObject, 0.2f));
        }

        private void SwitchGatesText()
        {
            switch (_gatesType)
            {
                case GatesType.Positive:
                    symbolGate = "+";
                    break;
                case GatesType.Negative:
                    symbolGate = "-";
                    break;
                case GatesType.Multyplying:
                    symbolGate = "X";
                    break;
            }

            textGates.text = symbolGate + numberGates;
        }
    }
}
