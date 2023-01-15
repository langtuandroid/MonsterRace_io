using System.Collections;
using UnityEngine;

namespace PlayKing.Cor
{
    public class CharacterStatesAnimation : MonoBehaviour
    {
        [SerializeField] Animator _animCharacter;
        [SerializeField] Animator _animMonster;
        private bool isMonsterStage;

        public void RunAnimation(bool isRun)
        {
            if(isMonsterStage)
            {
                _animMonster.SetBool("Run", isRun);
                return;
            }

            _animCharacter.SetBool("Run", isRun);
        }

        public void JumpAnimation()
        {
            _animCharacter.SetTrigger("Jump");
        }

        public void AttackAnimation()
        {
            _animMonster.SetTrigger("Attack");
        }

        public void StopAnimations()
        {
            _animCharacter.enabled = false;
            _animMonster.enabled = false;
        }

        public void KonckAnimation()
        {
            _animCharacter.SetTrigger("Knock");
        }

        public void WakeUpAnimation()
        {
            _animCharacter.SetTrigger("WakeUp");
        }

        public void DecreaseAnimation()
        {
            _animCharacter.SetTrigger("Decrease");
        }

        public void DanceAnimation()
        {
            _animMonster.SetTrigger("Dance");
        }

        public void IsMonsterStage(bool monsterStage)
        {
            isMonsterStage = monsterStage;
        }
    }
}