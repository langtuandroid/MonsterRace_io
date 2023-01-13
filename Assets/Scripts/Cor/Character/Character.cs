using System.Collections;
using UnityEngine;
using DG.Tweening;

namespace PlayKing.Cor
{
    public class Character : MonoBehaviour
    {
        [SerializeField] GameObject crown;
        [SerializeField] ParticleSystem effectDamage;
        [SerializeField] GameObject canvas;
        [SerializeField] CharacterColorType _characterColorType;
        [SerializeField] private bool isPlayer;

        private bool isDeactiveCharacter;
        
        StackBalls _stackBalls;
        CharacterRagdoll _characterRagdoll;
        CharacterStates _characterStates;
        CharacterSkins _characterSkins;
        BallsMonster _ballsMoster;
        Leaderboard leaderboard;

        private void Start()
        {
            _stackBalls = GetComponent<StackBalls>();
            _characterRagdoll = GetComponent<CharacterRagdoll>();
            _characterStates = GetComponentInParent<CharacterStates>();
            _characterSkins = GetComponentInParent<CharacterSkins>();
            leaderboard = GameObject.FindObjectOfType<Leaderboard>();
        }

        public void SetCharacterSettings(CharacterColorType characterColorType)
        {
            _characterColorType = characterColorType;
        }

        public void KnockCharacter()
        {
            effectDamage.Play();
            _stackBalls.DestroyedStack();
            _characterStates.Knock();
        }

        public void CrownActive(bool isActive)
        {
            crown.SetActive(isActive);
        }

        public void JumpToMontser()
        {
            transform.DOJump(new Vector3(_ballsMoster.transform.position.x,
                _ballsMoster.transform.position.y + 1f, _ballsMoster.transform.position.z), 4f, 1, 0.5f);
        }

        public void KillCharacter(Transform t)
        {
            effectDamage.transform.parent = null;
            effectDamage.Play();
            _characterStates.Stop();
            _characterStates.CharacterDie();
            _characterRagdoll.ActiveteRagdoll(t);
            _characterSkins.ChangeDieSkin();
            Destroy(canvas);
            gameObject.GetComponent<Collider>().enabled = false;
            StartCoroutine(IE_Die());
        }

        public void KilledField(Transform p)
        {
            _characterStates.CharacterDie();
            transform.LookAt(p);
        }

        public void ActiveCharacter(bool isActive)
        {
            isDeactiveCharacter = isActive;
        }

        private IEnumerator IE_Die()
        {
            yield return new WaitForSeconds(2.5f);

            transform.DOMoveY(-5f, 1.2f);
            _characterRagdoll.ON();
            Destroy(gameObject, 2.5f);
        }

        private void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("Ball"))
            {
                CollectableBall _ball = other.GetComponent<CollectableBall>();
                
                if (!_ball.IsTrueCharacter(_characterColorType))
                    return;

                _stackBalls.AddCollectableBall(_ball);
                if (isPlayer) { VibrationController.Instance.ClaimVibration(); }
            }

            if (other.CompareTag("Character"))
            {
                Character character = other.GetComponent<Character>();
                StackBalls stackBalls = other.GetComponent<StackBalls>();

                if (isDeactiveCharacter)
                    return;

                if (_stackBalls.AmmountBalls() == stackBalls.AmmountBalls())
                {
                    return;
                }

                if (_stackBalls.AmmountBalls() >= stackBalls.AmmountBalls())
                {
                    other.GetComponent<Character>().KnockCharacter();
                    if (isPlayer) { VibrationController.Instance.KnockVibration(); }
                    return;
                }

                if (isPlayer) { VibrationController.Instance.KnockVibration(); }
                KnockCharacter();
            }
        }

        private void OnTriggerStay(Collider other)
        {
            if (other.CompareTag("MonsterFields"))
            {
                _ballsMoster = other.GetComponentInParent<BallsMonster>();

                _stackBalls.UnstackCollectablekBalls(_ballsMoster);
                leaderboard.AddScoreMemeber(_characterColorType, _ballsMoster.GetFillingPercent());

                if (_ballsMoster.IsFullMonster())
                {
                    _characterStates.CharacterTransformation(_ballsMoster);
                    _stackBalls.ClearStack();
                }

                if (_stackBalls.AmmountBalls() == 0)
                    return; 

                if (isPlayer) { VibrationController.Instance.UnstackVibration(); }
            }
        }
    }
}
