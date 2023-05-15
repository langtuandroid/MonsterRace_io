using System.Runtime.CompilerServices;
using UnityEngine;

namespace Core
{
    public class CharacterAnimation : MonoBehaviour
    {
        #region Variables

        [SerializeField] private Animator animCharacter;
      
        #endregion

        public void SetAnimator(Animator anim) => animCharacter = anim;

        public void RunAnimation(bool isRun)
        {
            if(animCharacter != null)
                animCharacter.SetBool("Run", isRun);
        }

        public void FlyingAnimation(bool isFlying) => animCharacter.SetBool("Flying", isFlying);

        public void JumpAnimation() => animCharacter.SetTrigger("Jump");

        public void AttackAnimation() => animCharacter.SetTrigger("Attack");

        public void KnockAnimation() => animCharacter.SetTrigger("Knock");

        public void WakeUpAnimation() => animCharacter.SetTrigger("WakeUp");

        public void DecreaseAnimation() => animCharacter.SetTrigger("Decrease");

        public void LandingAnimation() => animCharacter.SetTrigger("Landing");

        public void DanceAnimation()
        {
            if (animCharacter != null)
                animCharacter.SetTrigger("Dance");
        }
    }
}