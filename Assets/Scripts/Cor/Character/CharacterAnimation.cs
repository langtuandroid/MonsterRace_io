using UnityEngine;

namespace Cor
{
    public class CharacterAnimation : MonoBehaviour
    {
        #region Variables

        [SerializeField] Animator _animCharacter;

        #endregion

        public void SetAnimator(Animator anim) => _animCharacter = anim;

        public void RunAnimation(bool isRun) => _animCharacter.SetBool("Run", isRun);

        public void JumpAnimation() => _animCharacter.SetTrigger("Jump");

        public void AttackAnimation() => _animCharacter.SetTrigger("Attack");

        public void FlyingAnimation(bool isFlying) => _animCharacter.SetBool("Flying", isFlying);

        public void KonckAnimation() => _animCharacter.SetTrigger("Knock");

        public void WakeUpAnimation() => _animCharacter.SetTrigger("WakeUp");

        public void DecreaseAnimation() => _animCharacter.SetTrigger("Decrease");

        public void LandingAnimation() => _animCharacter.SetTrigger("Landing");
    }
}