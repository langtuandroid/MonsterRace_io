using UnityEngine;
using TMPro;
using DG.Tweening;
using Core.MyPool;

namespace Core
{
    public class Gates : MonoBehaviour
    {
        #region Variables

        [SerializeField] private GatesType _gatesType;
        [SerializeField] private GameObject phon;
        [SerializeField] private TextMeshProUGUI textGates;
        [SerializeField] private int numberGates;
        [SerializeField] private CollectableBall[] collectableBalls;
        
        private int _index;
        private bool _isActive;

        private CharacterColorType _characterColor;
        private StackBalls _stackBalls;
        private GatesSpawner _gatesSpawner;

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

        public void ActiveBonus(StackBalls stackBalls, CharacterColorType characterColorType)
        {
            if (_isActive)
                return;

            _isActive = true;
            _stackBalls = stackBalls;
            _characterColor = characterColorType;

            switch (_characterColor)
            {
                case CharacterColorType.Blue:
                    _index = 0;
                    break;
                case CharacterColorType.Yellow:
                    _index = 1;
                    break;
                case CharacterColorType.Green:
                    _index = 2;
                    break;
                case CharacterColorType.Violet:
                    _index = 3;
                    break;
                case CharacterColorType.Red:
                    _index = 4;
                    break;
            }

            switch (_gatesType)
            {
                case GatesType.Positive:
                    PositiveGate();
                    break;
                case GatesType.Negative:
                    NegativeGate();
                    break;
                case GatesType.Multyplying:
                    MultiplyGate();
                    break;
            }

            phon.SetActive(false);
            _gatesSpawner.RemoveGate(this);
            transform.DOScale(0, 0.5f).OnComplete(() => Destroy(gameObject, 0.2f));
        }

        private void PositiveGate()
        {
            for (int i = 0; i < numberGates; i++)
            {
                GameObject ball = NightPool.Spawn(collectableBalls[_index].gameObject, transform.position, transform.rotation);
                _stackBalls.AddCollectableBall(ball.GetComponent<CollectableBall>(), false);
            }
        }

        private void NegativeGate()
        {
            for (int i = 0; i < numberGates; i++)
            {
                _stackBalls.RemoveCollectableBall();
            }
        }

        private void MultiplyGate()
        {
            int number = _stackBalls.GetCountBalls() + (_stackBalls.GetCountBalls() / 2);
            float timer = 0;

            for (int i = 0; i < number; i++)
            {
                GameObject ball = NightPool.Spawn(collectableBalls[_index].gameObject, transform.position, transform.rotation);
                _stackBalls.AddCollectableBall(ball.GetComponent<CollectableBall>(), false);
                ball.SetActive(false);
                DOVirtual.DelayedCall(timer, () => ball.SetActive(true));
                timer += 0.03f;
            }
        }

        private void SwitchGatesText()
        {
            string symbolGate = null;

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
