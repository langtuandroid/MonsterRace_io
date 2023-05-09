using System;
using System.Collections;
using UnityEngine;
using DG.Tweening;

namespace Cor
{
    public class CharacterStates : MonoBehaviour
    {
        #region Variables

        [SerializeField] Character _character;
        [SerializeField] CharacterMonster _characterMonster;
        [SerializeField] CharacterAnimation _characterStatesAnimation;
        [SerializeField] CharacterSkins _characterSkins;
        [SerializeField] PlayerCharacterSkin _playerCharacterSkin;
        [SerializeField] CharacterCanvas _characterCanvas;
        [SerializeField] PlayerMovement _playerMovement;
        [SerializeField] BotMovement _botMovement;
        [SerializeField] BotPointer _botPointer;
        [SerializeField] CharacterFight _characterFight;
        [SerializeField] private bool isPlayerCharacter;
        [SerializeField] private bool isMonsterStage;
        [SerializeField] private bool isDie;

        private ArenaManager _arena;
        private CollectableMonster _monster;
        private BallsMonster _ballsMonster;
        private SkinsController skinsController;
        private Skin skin;

        #endregion

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

        private void Start()
        {
            _arena = GameObject.FindObjectOfType<ArenaManager>();
            skinsController = GameObject.FindObjectOfType<SkinsController>();
            LevelManager.Instance.OnLevelCompleted += Finish;
            if (!IsPlayerCharacter())
                _arena.AddBot(_character);
        }

        //public void SetSpeedPlatfrom(Transform platform)
        //{
        //    if (IsPlayerCharacter()) 
        //    {
        //        _playerMovement.transform.parent = platform;
        //        return;
        //    }

        //    _botMovement.transform.parent = platform;
        //}

        //public void SetNullPlaform()
        //{
        //    if (IsPlayerCharacter())
        //    {
        //        _playerMovement.transform.parent = null;
        //        return;
        //    }
        //    _botMovement.transform.parent = null;
        //}

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

            if (!IsPlayerCharacter()) { _arena.RemoveBot(_character); }
            if (IsPlayerCharacter()) { _arena.RemovePlayer(); }
        }

        public void Die()
        {
            Destroy(_characterCanvas.gameObject);
            Destroy(gameObject, 0.3f);
        }

        public void Attack()
        {
            _characterStatesAnimation.AttackAnimation();
            StopMovement(true);
        }

        public void MoveRetrun()
        {
            StopMovement(false);
        }

        public void Knock(Transform knockDir)
        {
            if (_playerMovement != null)
            {
                _playerMovement.LockControll(true);
            }

            if (_botMovement != null)
            {
                _botMovement.StopMovement(true);
                _botMovement.PushBot(knockDir);
            }

            _characterStatesAnimation.KonckAnimation();
            StartCoroutine(IE_WakeUp());
            StartCoroutine(IE_CanMove(1.5f));
        }

        public void Push(Transform pushDir, float force)
        {
            if (_playerMovement != null)
            {
                _playerMovement.LockControll(true);
                _playerMovement.PushPlayer(pushDir, force);
                StartCoroutine(IE_CanMove(0.5f));
            }

            if (_botMovement != null)
            {
                _botMovement.StopMovement(true);
                _botMovement.ThrowBot(pushDir, force);
                StartCoroutine(IE_CanMove(1f));
            }
        }

        public void RootToFinish()
        {
            _characterStatesAnimation.LandingAnimation();
            _playerMovement.transform.DORotate(new Vector3(0, -90f, 0f), 0.5f);
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

            if(_playerMovement != null)
                _playerMovement.MovementToTarget(_monster.transform);

            _character.JumpToMontser();
        }

        private IEnumerator IE_SetMonsterSettings()
        {
            yield return new WaitForSeconds(0.85f);

            _ballsMonster.transform.parent = _characterMonster.transform;
            _ballsMonster.transform.position = _characterMonster.MonsterPoint().position;
            _ballsMonster.transform.rotation = _characterMonster.MonsterPoint().rotation;

            if (!isPlayerCharacter)
            {
                _ballsMonster.ActiveMontserHead(_characterSkins.Type());
                _ballsMonster.SetupMonster(false);
            }

            if (isPlayerCharacter)
            { 
                _ballsMonster.ActiveMontserHead(_playerCharacterSkin.GetHeadType());
                _ballsMonster.SetupMonster(true);
            }
           
            _characterMonster.SetMonsterAnimator(_monster.Type());

            if (IsPlayerCharacter())
            {
                CameraController.Instance.CharacterCam(false);
                CameraController.Instance.ChangeMonsterCam(true);
                LevelManager.Instance.LevelFight();
                TutorialPopup popupController = GameObject.FindObjectOfType<TutorialPopup>();
                popupController.NextPopupActive();
            }
        }

        private IEnumerator IE_ActivetedMonster()
        {
            yield return new WaitForSeconds(0.9f);

            _character.gameObject.SetActive(false);
            _characterMonster.gameObject.SetActive(true);
            _monster.DeactiveMonster();

            if (_playerMovement != null)
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

            skin = skinsController.GetProgressSkin();
            _playerMovement.JumpToTarget(skin.Point());
        }
    }
}