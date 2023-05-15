using System;
using System.Collections;
using UnityEngine;
using DG.Tweening;

namespace Core
{
    public class Character : MonoBehaviour
    {
        #region Variables

        [SerializeField] private GameModeType gameMode;
        [SerializeField] private CharacterColorType _characterColorType;
        [SerializeField] private GameObject crown;
        [SerializeField] private ParticleSystem effectDamage;
        [SerializeField] private ParticleSystem effectDie;
        [SerializeField] private StackBalls _stackBalls;
        [SerializeField] private CharacterStates _characterStates;
        [SerializeField] private CharacterBonus _characterBonus;
        private bool _isDeactiveCharacter;
        private bool _canUnstack;
        private CollectableMonster _ballsMoster;
        private Leaderboard _leaderboard;

        #endregion

        public void SetCharacterSettings(CharacterColorType characterColorType, Leaderboard leaderboard)
        {
            _characterColorType = characterColorType;
            _leaderboard = leaderboard;
        }

        public void CrownActive(bool isActive) => crown.SetActive(isActive);

        public void ActiveCharacter(bool isActive) => _isDeactiveCharacter = isActive;

        public void JumpToMontser()
        {
            transform.DOJump(new Vector3(_ballsMoster.transform.position.x,
                _ballsMoster.transform.position.y + 1f, _ballsMoster.transform.position.z), 4f, 1, 0.5f);
        }

        public void KnockCharacter(Transform m)
        {
            effectDamage.Play();
            _stackBalls.DestroyedStack();
            _characterStates.Knock(m);
            _isDeactiveCharacter = true;
        }

        public void KillCharacter()
        {
            effectDie.transform.parent = null;
            effectDie.Play();
            gameObject.GetComponent<Collider>().enabled = false;
            if(_characterStates != null) _characterStates.CharacterDie();
            if(_leaderboard != null) _leaderboard.RemoveMember(_characterColorType);
            if (_characterBonus != null) _characterBonus.DieCharacter();
            StartCoroutine(IE_Die());
        }

        private IEnumerator IE_Die()
        {
            yield return new WaitForSeconds(2.5f);

            transform.DOScale(0, 0.9f);
            Destroy(gameObject, 2.5f);
        }

        #region CharacterCollisions

        private void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("Ball"))
            {
                CollectableBall _ball = other.GetComponent<CollectableBall>();
                if (!_ball.IsTrueCharacter(_characterColorType))
                    return;
                _stackBalls.AddCollectableBall(_ball, _characterStates.IsPlayerCharacter());
                if (_characterStates.IsPlayerCharacter())
                    VibrationManager.Instance.WeakVibration();
            }

            if (other.CompareTag("Character"))
            {
                if (gameMode == GameModeType.Bonus)
                    return;

                StackBalls stackBalls = other.GetComponent<StackBalls>();

                if (_isDeactiveCharacter)
                    return;

                if (_stackBalls.GetCountBalls() == stackBalls.GetCountBalls())
                    return;
                

                if (_stackBalls.GetCountBalls() >= stackBalls.GetCountBalls())
                {
                    other.GetComponent<Character>().KnockCharacter(transform);
                    if (_characterStates.IsPlayerCharacter())
                        VibrationManager.Instance.HeavyVibration();

                    return;
                }

                if (_characterStates.IsPlayerCharacter())
                    VibrationManager.Instance.HeavyVibration();

                KnockCharacter(other.transform);
            }

            if(other.CompareTag("Gate"))
            {
                Gates gates = other.gameObject.GetComponent<Gates>();
                gates.ActiveBonus(_stackBalls, _characterColorType);
            }
        }
        
        private void OnTriggerStay(Collider other)
        {
            if (!other.CompareTag("MonsterFields")) 
                return;
            
            _ballsMoster = other.GetComponentInParent<CollectableMonster>();

            if (_ballsMoster.IsDeactivetedMonster())
                return;

            if (_characterStates.IsDie())
                return;

            _stackBalls.UnstackCollectablekBalls(_ballsMoster);
            _leaderboard.AddScoreMember(_characterColorType, _ballsMoster.GetFillingPercent(_characterColorType));

            if (_ballsMoster.IsFullMonster())
            {
                if (_ballsMoster.IsDeactivetedMonster())
                    return;

                _characterStates.CharacterTransformation(_ballsMoster);
                _stackBalls.ClearStack();
            }

            if (_stackBalls.GetCountBalls() == 0)
                return;

            if (_characterStates.IsPlayerCharacter())
                VibrationManager.Instance.LowVibration();
        }
        
        private void OnTriggerExit(Collider other)
        {
            if (other.CompareTag("MonsterFields"))
                _canUnstack = false;
        }

        #endregion
    }
}
