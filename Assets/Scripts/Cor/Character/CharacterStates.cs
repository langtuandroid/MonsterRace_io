using System.Collections;
using UnityEngine;
using UnityEngine.Events;

public enum CharacterColorType
{
    Blue,
    Green,
    Yellow,
    Violet,
    Red,
    Purple,
    Neutral
}

namespace PlayKing.Cor
{
    public class CharacterStates : MonoBehaviour
    {
        [SerializeField] Character _character;
        [SerializeField] CharacterMonster _characterMonster;
        [SerializeField] CharacterStatesAnimation _characterStatesAnimation;
        [SerializeField] CharacterSkins _characterSkins;
        [SerializeField] CharacterCanvas _characterCanvas;
        [SerializeField] PlayerMovement _playerMovement;
        [SerializeField] BotMovement _botMovement;
        [SerializeField] private bool isPlayer;
        [SerializeField] private bool isMonsterStage;

        [HideInInspector]
        public UnityEvent OnDie;

        Arena _arena;
        public BallsMonster monster;

        public bool IsMonsterStage()
        {
            return isMonsterStage;
        }

        private void Start()
        {
            _arena = GameObject.FindObjectOfType<Arena>();
            if (!isPlayer) { _arena.AddBot(this); }
        }

        private void Update()
        {
            if (!isPlayer)
                return;

            if (Input.GetKeyDown("d"))
            {
                CharacterTransformation(monster);
            }
        }

        public void CharacterTransformation(BallsMonster ballsMonster)
        {
            if (isMonsterStage)
                return;

            monster = ballsMonster;

            if (_playerMovement != null)
                _playerMovement.LockControll(true);

            _characterStatesAnimation.JumpAnimation();
            _characterStatesAnimation.IsMonsterStage(true);
            _characterCanvas.SetMonsterTarget();
            _characterMonster.SetMonster(ballsMonster.Type());
            StartCoroutine(IE_CharacterInMonster());
            StartCoroutine(IE_ActivetedMonster());
            isMonsterStage = true;
        }

        public void StopMovement(bool isStop)
        {
            if (isStop)
            {
                _characterStatesAnimation.RunAnimation(false);

                if (_playerMovement != null)
                    _playerMovement.LockControll(true);

                if (_botMovement != null)
                    _botMovement.StopMovement(true);

                return;
            }

            if (_playerMovement != null)
                _playerMovement.LockControll(false);

            if (_botMovement != null)
                _botMovement.StopMovement(false);
        }

        public void CharacterDie()
        {
            OnDie.Invoke();
            _characterStatesAnimation.DecreaseAnimation();
            Destroy(_characterCanvas.gameObject);
            if (_botMovement != null)
                _botMovement.StopMovement(true);

            if (!isPlayer) { _arena.RemoveBot(this); }
            if (isPlayer) { _arena.RemovePlayer(); }
        }

        public void Dance()
        {
            _characterStatesAnimation.DanceAnimation();
            _characterCanvas.gameObject.SetActive(false);
        }

        public void Die()
        {
            Destroy(_characterCanvas.gameObject);
            Destroy(gameObject, 0.3f);
        }

        public void Attack()
        {
            _characterStatesAnimation.AttackAnimation();
        }

        public void Knock(Transform knockDir)
        {
            if (_playerMovement != null)
                _playerMovement.LockControll(true);

            if (_botMovement != null)
            {
                _botMovement.StopMovement(true);
                _botMovement.PushBot(knockDir);
            }
            _characterStatesAnimation.KonckAnimation();

            StartCoroutine(IE_WakeUp());
            StartCoroutine(CanMove());
        }

        private IEnumerator IE_CharacterInMonster()
        {
            yield return new WaitForSeconds(0.5f);

            if(_playerMovement != null)
                _playerMovement.MovementToTarget(monster.transform);

            _character.JumpToMontser();
            if(isPlayer)
                CameraController.Instance.ChangeMonsterStateCam();
        }

        private IEnumerator IE_ActivetedMonster()
        {
            yield return new WaitForSeconds(0.9f);

            _character.gameObject.SetActive(false);
            _characterMonster.gameObject.SetActive(true);
            _characterMonster.AttackFieldActive(true);
            monster.DeactiveMonster();

            if (_playerMovement != null)
                _playerMovement.LockControll(false);
        }

        private IEnumerator IE_WakeUp()
        {
            yield return new WaitForSeconds(1f);

            _characterStatesAnimation.WakeUpAnimation();
        }

        private IEnumerator CanMove()
        {
            yield return new WaitForSeconds(1.5f);

            StopMovement(false);
            _botMovement.RestartMovement();
            _character.ActiveCharacter(false);
        }
    }
}
