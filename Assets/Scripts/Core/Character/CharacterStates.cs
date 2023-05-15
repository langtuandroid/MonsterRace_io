using System;
using System.Collections;
using UnityEngine;
using DG.Tweening;

namespace Core
{
    public class CharacterStates : MonoBehaviour
    {
        #region Variables

        [SerializeField] private Character _character;
        [SerializeField] private CharacterMonster _characterMonster;
        [SerializeField] private CharacterAnimation _characterStatesAnimation;
        [SerializeField] private CharacterSkins _characterSkins;
        [SerializeField] private PlayerCharacterSkin _playerCharacterSkin;
        [SerializeField] private CharacterCanvas _characterCanvas;
        [SerializeField] private PlayerMovement _playerMovement;
        [SerializeField] private BotMovement _botMovement;
        [SerializeField] private BotPointer _botPointer;
        [SerializeField] private CharacterFight _characterFight;
        [SerializeField] private bool isPlayerCharacter;
        [SerializeField] private bool isMonsterStage;
        [SerializeField] private bool isDie;
        
        private CollectableMonster _monster;
        private BallsMonster _ballsMonster;
        private SkinsController _skinsController;
        private Skin _skin;

        #endregion

        public bool IsDie()
        {
            return isDie;
        }

        public bool IsPlayerCharacter()
        {
            return isPlayerCharacter;
        }

        private void OnEnable()
        {
            _characterFight.OnStartAttack += Attack;
            _characterFight.OnEndAttack += MoveRetrun;
        }

        private void OnDestroy()
        {
            _characterFight.OnStartAttack -= Attack;
            _characterFight.OnEndAttack -= MoveRetrun;
        }

        public void Init(SkinsController skinsController)
        {
            _skinsController = skinsController;
            LevelManager.Instance.OnLevelCompleted += Finish;
            if (!IsPlayerCharacter())
                ArenaManager.Instance.AddBot(_character);
        }
        
        public void SetFlying(bool isFlying)
        {
            _characterStatesAnimation.FlyingAnimation(isFlying);
        }

        public void CharacterTransformation(CollectableMonster monster)
        {
            if (isMonsterStage)
                return;

            _monster = monster;
            _monster.DeactiveMonster();
            _ballsMonster = _monster.GetComponentInChildren<BallsMonster>();
            
            if (_playerMovement != null)
                _playerMovement.LockControll(true);

            _characterStatesAnimation.JumpAnimation();
            _characterCanvas.SetMonsterTarget();

            StartCoroutine(IE_CharacterInMonster());
            StartCoroutine(IE_SetMonsterSettings());
            StartCoroutine(IE_ActivetedMonster());
            isMonsterStage = true;
        }
        
        public void CharacterDie()
        {
            isDie = true;
            _characterStatesAnimation.DecreaseAnimation();
            Destroy(_characterCanvas.gameObject);

            if (isPlayerCharacter)
            {
                ArenaManager.Instance.RemovePlayer();
                return;
            }
            
            _botPointer.Remove();
            _botMovement.StopMovement(true);
            ArenaManager.Instance.RemoveBot(_character);
        }

        public void Die()
        {
            Destroy(_characterCanvas.gameObject);
            Destroy(gameObject, 0.3f);
        }

        public void Knock(Transform knockDir)
        {
            switch (isPlayerCharacter)
            {
                case true:
                    _playerMovement.LockControll(true);
                    break;
                case false:
                    _botMovement.StopMovement(true);
                    _botMovement.PushBot(knockDir);
                    break;
            }

            _characterStatesAnimation.KnockAnimation();
            StartCoroutine(IE_WakeUp());
            StartCoroutine(IE_CanMove(1.5f));
        }

        public void Push(Transform pushDir, float force)
        {
            if (isPlayerCharacter)
            {
                _playerMovement.LockControll(true);
                _playerMovement.PushPlayer(pushDir, force);
                StartCoroutine(IE_CanMove(0.5f));
                return;
            }

            _botMovement.StopMovement(true);
            _botMovement.ThrowBot(pushDir, force);
            StartCoroutine(IE_CanMove(1f));
        }
        
        public void RootToFinish()
        {
            _characterStatesAnimation.LandingAnimation();
            _playerMovement.transform.DORotate(new Vector3(0, -90f, 0f), 0.5f);
        }

        private void StopMovement(bool isStop)
        {
            _characterStatesAnimation.RunAnimation(!isStop);

            if (isPlayerCharacter)
            {
                _playerMovement.LockControll(!isStop);
                return;
            }
            
            _botMovement.StopMovement(!isStop);
        }
        
        private void Attack()
        {
            _characterStatesAnimation.AttackAnimation();
            StopMovement(true);
        }

        private void MoveRetrun()
        {
            StopMovement(false);
        }
        
        private void Finish()
        {
            if (!IsPlayerCharacter())
                return;

            StartCoroutine(IE_StartJump());
            StartCoroutine(IE_Jump());
        }

        private IEnumerator IE_CharacterInMonster()
        {
            yield return new WaitForSeconds(0.5f);

            if(isPlayerCharacter)
                _playerMovement.MovementToTarget(_monster.transform);

            _character.JumpToMontser();
        }

        private IEnumerator IE_SetMonsterSettings()
        {
            yield return new WaitForSeconds(0.85f);

            _ballsMonster.transform.parent = _characterMonster.transform;
            _ballsMonster.transform.position = _characterMonster.MonsterPoint().position;
            _ballsMonster.transform.rotation = _characterMonster.MonsterPoint().rotation;

            switch (isPlayerCharacter)
            {
                case true:
                    _ballsMonster.ActiveMonsterHead(_characterSkins.Type());
                    _ballsMonster.SetupMonster(false);
                    CameraController.Instance.CharacterCam(false);
                    CameraController.Instance.ChangeMonsterCam(true);
                    LevelManager.Instance.LevelFight();
                    TutorialPopup popupController = FindObjectOfType<TutorialPopup>();
                    popupController.NextPopupActive();
                    break;
                case false:
                    _ballsMonster.ActiveMonsterHead(_playerCharacterSkin.GetHeadType());
                    _ballsMonster.SetupMonster(true);
                    break;
            }

            _characterMonster.SetMonsterAnimator(_monster.Type());
        }

        private IEnumerator IE_ActivetedMonster()
        {
            yield return new WaitForSeconds(0.9f);

            _character.gameObject.SetActive(false);
            _characterMonster.gameObject.SetActive(true);
            _monster.DeactiveMonster();

            if (isPlayerCharacter)
                _playerMovement.LockControll(false);
        }

        private IEnumerator IE_WakeUp()
        {
            yield return new WaitForSeconds(1f);

            _characterStatesAnimation.WakeUpAnimation();
        }

        private IEnumerator IE_CanMove(float time)
        {
            yield return new WaitForSeconds(time);

            StopMovement(false);
            if(_botMovement != null)
                _botMovement.RestartMovement();
            _character.ActiveCharacter(false);
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

            _skin = _skinsController.GetProgressSkin();
            _playerMovement.JumpToTarget(_skin.Point());
        }
    }
}