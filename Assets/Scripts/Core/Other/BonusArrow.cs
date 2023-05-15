using UnityEngine;

namespace Core
{
    public class BonusArrow : MonoBehaviour
    {
        #region Variables

        [SerializeField] private BonusButton bonusButton;
        [SerializeField] private Animator animArrow;

        #endregion

        public void SetMultiply(int number) => bonusButton.SetBonus(number);

        public void StopArrow()
        {
            animArrow = GetComponent<Animator>();
            animArrow.enabled = false;
        }
    }
}
