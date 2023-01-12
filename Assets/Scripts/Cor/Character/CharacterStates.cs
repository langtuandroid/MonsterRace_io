using System.Collections;
using UnityEngine;

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
        [SerializeField] CharacterColorType characterColorType;
        [SerializeField] string name;
        [SerializeField] Color color;
        [SerializeField] Character _character;
        [SerializeField] CharacterMonster _characterMonster;
        [SerializeField] CharacterStatesAnimation _characterStatesAnimation;
        [SerializeField] CharacterCanvas _characterCanvas;
        [SerializeField] PlayerMovement _playerMovement;
        [SerializeField] BotMovement _botMovement;
        [SerializeField] MeshRenderer basket;
        [SerializeField] Color basketColor;
        [SerializeField] private bool isPlayer;
        private bool isMonsterStage;

        Arena _arena;
        BallsMonster monster;
        Leaderboard leaderboard;

        private void Start()
        {
            leaderboard = GameObject.FindObjectOfType<Leaderboard>();
            leaderboard.AddMember(_character,characterColorType, color, name);
            _character.SetCharacterSettings(characterColorType);
            basket.material.color = basketColor;
            _arena = GameObject.FindObjectOfType<Arena>();
            if (!isPlayer) { _arena.AddBot(this); }
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
            StartCoroutine(IE_CharacterInMonster());
            StartCoroutine(IE_ActivetedMonster());
            isMonsterStage = true;
        }

        public void Stop()
        {
            _characterStatesAnimation.RunAnimation(false);
            _botMovement.StopMovement(true);
        }

        public void CharacterDie()
        {
            _characterStatesAnimation.StopAnimations();
            if (_botMovement != null)
                _botMovement.StopMovement(true);

            if (!isPlayer) { _arena.RemoveBot(this); }
            if (isPlayer) { _arena.RemovePlayer(); }
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

        public void Knock()
        {
            if (_playerMovement != null)
                _playerMovement.LockControll(true);

            if (_botMovement != null)
                _botMovement.StopMovement(true);

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
            CameraController.Instance.ChangeMonsterStateCam();
        }

        private IEnumerator IE_ActivetedMonster()
        {
            yield return new WaitForSeconds(0.9f);

            monster.gameObject.SetActive(false);
            _character.gameObject.SetActive(false);
            _characterMonster.gameObject.SetActive(true);
           
            if (_playerMovement != null)
                _playerMovement.LockControll(false);
        }

        private IEnumerator IE_WakeUp()
        {
            yield return new WaitForSeconds(0.5f);

            _characterStatesAnimation.WakeUpAnimation();
        }

        private IEnumerator CanMove()
        {
            yield return new WaitForSeconds(2.2f);

            if (_playerMovement != null)
                _playerMovement.LockControll(false);

            if (_botMovement != null)
                _botMovement.StopMovement(false);

            _character.ActiveCharacter(false);
        }
    }
}
