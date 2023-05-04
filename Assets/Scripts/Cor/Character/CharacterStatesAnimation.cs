using UnityEngine;

namespace Cor
{
    public class CharacterStatesAnimation : MonoBehaviour
    {
        #region Variables

        [SerializeField] Animator _animCharacter;
        [SerializeField] Animator _animMonster;
        private bool isMonsterStage;

        #endregion

        public void IsMonsterStage(bool monsterStage)
        {
            isMonsterStage = monsterStage;
        }

        public void AddMonsterAnimator(Animator anim)
        {
            _animMonster = anim;
        }

        public void RunAnimation(bool isRun)
        {
            if(isMonsterStage)
            {
                if(_animMonster != null)
                    _animMonster.SetBool("Run", isRun);
                return;
            }

            if(_animCharacter != null)
                _animCharacter.SetBool("Run", isRun);
        }

        public void JumpAnimation()
        {
            if (isMonsterStage) { _animMonster.SetTrigger("Jump"); }
            _animCharacter.SetTrigger("Jump");
        }

        public void AttackAnimation()
        {
            if(_animMonster != null)
                _animMonster.SetTrigger("Attack");
        }

        public void StopAnimations()
        {
            _animCharacter.enabled = false;
            _animMonster.enabled = false;
        }

        public void FlyingAnimation(bool isFlying)
        {
            if(isMonsterStage)
            {
                if (_animMonster != null)
                    _animMonster.SetBool("Flying", isFlying);
                return;
            }

            if (_animCharacter != null)
                _animCharacter.SetBool("Flying", isFlying);
        }

        public void KonckAnimation() => _animCharacter.SetTrigger("Knock");

        public void WakeUpAnimation() => _animCharacter.SetTrigger("WakeUp");

        public void DecreaseAnimation() => _animCharacter.SetTrigger("Decrease");

        public void LandingAnimation() => _animMonster.SetTrigger("Landing");
    }
}