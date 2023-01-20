using System.Collections;
using UnityEngine;
using DG.Tweening;

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
        [SerializeField] BotPointer _botPointer;
        [SerializeField] private bool isPlayerCharacter;
        [SerializeField] private bool isMonsterStage;
        [SerializeField] private bool isDie;

        ArenaController _arena;
        public BallsMonster monster;
        SkinsController skinsController;
        Skin skin;

        public bool IsMonsterStage()
        {
            return isMonsterStage;
        }

        public bool IsDie()
        {
            return isDie;
        }

        public bool IsPlayerCharacter()
        {
            return isPlayerCharacter;
        }

        private void Start()
        {
            _arena = GameObject.FindObjectOfType<ArenaController>();
            skinsController = GameObject.FindObjectOfType<SkinsController>();
            LevelController.Instance.OnLevelCompleted.AddListener(Finish);
            if (!IsPlayerCharacter())
                _arena.AddBot(this);
        }

        private void Update()
        {
            if (!isPlayerCharacter)
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
            isDie = true;
            _characterStatesAnimation.DecreaseAnimation();
            if(!isPlayerCharacter)
                _botPointer.Remove();
            Destroy(_characterCanvas.gameObject);
            if (_botMovement != null)
                _botMovement.StopMovement(true);

            if (!IsPlayerCharacter()) { _arena.RemoveBot(this); }
            if (IsPlayerCharacter()) { _arena.RemovePlayer(); }
        }

        public void Dance()
        {
            _characterStatesAnimation.LandingAnimation();
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
            {
                _playerMovement.LockControll(true);
                _playerMovement.PushPlayer(knockDir);
            }

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

            if (IsPlayerCharacter())
            {
                CameraController.Instance.CharacterCam(false);
                CameraController.Instance.ChangeMonsterCam(true);
            }
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




        //finish Part

        private void Finish()
        {
            StartCoroutine(IE_StartJump());
            StartCoroutine(IE_Jump());
        }

        private IEnumerator IE_StartJump()
        {
            yield return new WaitForSeconds(0.5f);

            if(_characterCanvas != null)
                _characterCanvas.transform.DOScale(0, 0.5f);
            _characterStatesAnimation.JumpAnimation();
            _playerMovement.transform.DORotate(new Vector3(0f, 90f, 0f), 0.5f);
        }

        private IEnumerator IE_Jump()
        {
            yield return new WaitForSeconds(1.4f);

            skin = skinsController.GetProgressSkin();
            _playerMovement.JumpToTarget(skin.Point());
        }

        public void RootToFinish()
        {
            _characterStatesAnimation.LandingAnimation();
            _playerMovement.transform.DORotate(new Vector3(0, -90f, 0f), 0.5f);
        }
    }
}