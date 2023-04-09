using UnityEngine;
using TMPro;
using DG.Tweening;

namespace Cor
{
    public class Gates : MonoBehaviour
    {
        #region Variables

        [SerializeField] GatesType _gatesType;
        [SerializeField] GameObject phon;
        [SerializeField] TextMeshProUGUI textGates;
        [SerializeField] private int numberGates;
        [SerializeField] CollectableBall[] collectableBalls;
        private int index;
        private string symbolGate;
        private bool isActive;

        CharacterColorType _characterColor;
        StackBalls _stackBalls;
        GatesSpawner _gatesSpawner;

        #endregion

        public void SetGatesSettings(GatesSpawner gatesSpawner,GatesType gatesType)
        {
            transform.DOScale(transform.localScale, 0.5f).From(0);
            _gatesSpawner = gatesSpawner;
            _gatesType = gatesType;
            if(_gatesType != GatesType.Multyplying)
                numberGates = Random.Range(1, 10);
            if (_gatesType == GatesType.Multyplying)
                numberGates = Random.Range(2, 3);
            SwitchGatesText();
        }

        public void ActivetedBonus(StackBalls stackBalls, CharacterColorType characterColorType)
        {
            if (isActive)
                return;

            isActive = true;
            _stackBalls = stackBalls;
            _characterColor = characterColorType;

            switch (_characterColor)
            {
                case CharacterColorType.Blue:
                    index = 0;
                    break;
                case CharacterColorType.Yellow:
                    index = 1;
                    break;
                case CharacterColorType.Green:
                    index = 2;
                    break;
                case CharacterColorType.Violet:
                    index = 3;
                    break;
                case CharacterColorType.Red:
                    index = 4;
                    break;
                case CharacterColorType.Purple:
                    index = 5;
                    break;
            }

            switch (_gatesType)
            {
                case GatesType.Positive:
                    PositiveBonus();
                    break;
                case GatesType.Negative:
                    NegativeBonus();
                    break;
                case GatesType.Multyplying:
                    MultiplyBonus();
                    break;
            }

            phon.SetActive(false);
            _gatesSpawner.RemoveGate(this);
            transform.DOScale(0, 0.5f).OnComplete(() => Destroy(gameObject, 0.2f));
        }

        private void PositiveBonus()
        {
            for (int i = 0; i < numberGates; i++)
            {
                GameObject ball = Instantiate(collectableBalls[index].gameObject, transform.position, transform.rotation);
                _stackBalls.AddCollectableBall(ball.GetComponent<CollectableBall>(), false);
            }
        }

        private void NegativeBonus()
        {
            for (int i = 0; i < numberGates; i++)
            {
                _stackBalls.RemoveColleactbleBall();
            }
        }

        private void MultiplyBonus()
        {
            int number = _stackBalls.AmmountBalls() + (_stackBalls.AmmountBalls() / 2);
            float timer = 0;

            for (int i = 0; i < number; i++)
            {
                GameObject ball = Instantiate(collectableBalls[index].gameObject, transform.position, transform.rotation);
                _stackBalls.AddCollectableBall(ball.GetComponent<CollectableBall>(), false);
                ball.SetActive(false);
                DOVirtual.DelayedCall(timer, () => ball.SetActive(true));
                timer += 0.05f;
            }
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
