using UnityEngine;

namespace Cor
{
    public class BonusArrow : MonoBehaviour
    {
        #region Variables

        [SerializeField] BonusButton _bonusButton;
        [SerializeField] Animator animArrow;

        #endregion

        public void SetMultiply(int number)
        {
            _bonusButton.SetBonus(number);
        }

        public void StopArrow()
        {
            animArrow = GetComponent<Animator>();
            animArrow.enabled = false;
        }
    }
}
