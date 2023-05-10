using UnityEngine;
using DG.Tweening;

namespace Cor
{
    public class CharacterBonus : MonoBehaviour
    {
        #region Variables

        [SerializeField] Transform weaponPoint;
        [SerializeField] CharacterFight _characterFight;
        [SerializeField] BotFight botFight;
        [SerializeField] CharacterAnimation _characterAnimation;
        [SerializeField] PlayerMovement _playerMovement;
        [SerializeField] BotMovement _botMovement;
        [SerializeField] CharacterSkins characterSkins;
        [SerializeField] CharacterCanvas characterCanvas;
        [SerializeField] BotPointer botPointer;
        [SerializeField] Character character;
        [SerializeField] private float scale;
        [SerializeField] private bool isPlayer;

        private bool isDie;
        private WeaponSpawner weaponSpawner;

        #endregion

        private void OnEnable()
        {
            _characterFight.OnStartAttack += Attack;
            _characterFight.OnEndAttack += Return;
            LevelManager.Instance.OnLevelCompleted += Victory;
        }

        private void OnDestroy()
        {
            _characterFight.OnStartAttack -= Attack;
            _characterFight.OnEndAttack -= Return;
            LevelManager.Instance.OnLevelCompleted -= Victory;
        }

        public float GetScale()
        {
            return scale;
        }

        private void Start()
        {
            weaponSpawner = GameObject.FindObjectOfType<WeaponSpawner>();
           
            if (!isPlayer)
            {
                characterSkins.RandomSkin();
                ArenaManager.Instance.AddBot(character);
                weaponSpawner.SpawnWeapon(weaponPoint, Random.Range(0, 16));
                return;
            }

            weaponSpawner.SpawnWeapon(weaponPoint, weaponSpawner.GetIndex());
        }

        private void Attack()
        {
            _characterAnimation.AttackAnimation();
            StopMovement(true);
        }

        private void Return()
        {
            StopMovement(false);
        }

        public void Push(Transform dir)
        {
            if (_botMovement != null)
            {
                _botMovement.StopMovement(true);
                _botMovement.PushBot(dir);
            }
        }

        public void StopMovement(bool isStop)
        {
            if (isStop)
            {
                _characterAnimation.RunAnimation(false);

                if (_playerMovement != null)
                    _playerMovement.LockControll(true);

                if (_botMovement != null)
                    _botMovement.StopMovement(true);

                return;
            }

            if (_playerMovement != null)
                _playerMovement.LockControll(false);

            if (_botMovement != null)
            {
                _botMovement.RestartMovement();
                _botMovement.StopMovement(false);
            }
        }

        public void Upgrade(float number)
        {
            scale += number;
            transform.DOScale(scale, 0.3f);
            VibrationManager.Instance.HeavyVibration();
            if (isPlayer)
            {
                if (scale >= 5.4) CameraController.Instance.ChangeMonsterCam(true);
                PlayerSmashes.Instance.AddSmashes(1);
            }
        }

        public void DieCharacter()
        {
            if (isDie)
                return;

            isDie = true;

            _characterAnimation.DecreaseAnimation();
            if (isPlayer) 
            { 
                ArenaManager.Instance.RemovePlayer();
                Debug.Log("Die");
            }

            Destroy(characterCanvas.gameObject);
            _characterFight.DeactiveFight();
            StopMovement(true);
            if (!isPlayer)
            {
                botFight.StopFight();
                botPointer.Remove();
                ArenaManager.Instance.RemoveBot(character);
                DOVirtual.DelayedCall(2f, () => transform.DOScale(0, 0.5f).OnComplete(() => Destroy(gameObject)));
            }
        }

        private void Victory()
        {
            if (isDie)
                return;

            StopMovement(true);
            _characterAnimation.DanceAnimation();
            DOVirtual.DelayedCall(2f, () => UIManager.Instance.RewardScreen(true));
        }
    }
}
