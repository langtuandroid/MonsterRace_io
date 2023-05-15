using UnityEngine;
using DG.Tweening;

namespace Core
{
    public class CharacterBonus : MonoBehaviour
    {
        #region Variables

        [SerializeField] private Transform weaponPoint;
        [SerializeField] private CharacterFight characterFight;
        [SerializeField] private BotFight botFight;
        [SerializeField] private CharacterAnimation characterAnimation;
        [SerializeField] private PlayerMovement playerMovement;
        [SerializeField] private BotMovement botMovement;
        [SerializeField] private CharacterSkins characterSkins;
        [SerializeField] private CharacterCanvas characterCanvas;
        [SerializeField] private BotPointer botPointer;
        [SerializeField] private Character character;
        [SerializeField] private float scale;
        [SerializeField] private bool isPlayer;

        private bool _isDie;
        private WeaponSpawner _weaponSpawner;

        #endregion

        private void OnEnable()
        {
            characterFight.OnStartAttack += Attack;
            characterFight.OnEndAttack += Return;
            LevelManager.Instance.OnLevelCompleted += Victory;
        }

        private void OnDestroy()
        {
            characterFight.OnStartAttack -= Attack;
            characterFight.OnEndAttack -= Return;
            LevelManager.Instance.OnLevelCompleted -= Victory;
        }

        public float GetScale()
        {
            return scale;
        }

        private void Start()
        {
            _weaponSpawner = GameObject.FindObjectOfType<WeaponSpawner>();
           
            if (!isPlayer)
            {
                characterSkins.RandomSkin();
                ArenaManager.Instance.AddBot(character);
                _weaponSpawner.SpawnWeapon(weaponPoint, Random.Range(0, 16));
                return;
            }

            _weaponSpawner.SpawnWeapon(weaponPoint, _weaponSpawner.GetIndex());
        }

        private void Attack()
        {
            characterAnimation.AttackAnimation();
            StopMovement(true);
        }

        private void Return()
        {
            StopMovement(false);
        }

        public void Push()
        {
            if (botMovement != null)
            {
                botMovement.SetNullPoint();
            }
        }

        public void StopMovement(bool isStop)
        {
            if (isStop)
            {
                characterAnimation.RunAnimation(false);

                if (playerMovement != null)
                    playerMovement.LockControll(true);

                if (botMovement != null)
                    botMovement.StopMovement(true);

                return;
            }

            if (playerMovement != null)
                playerMovement.LockControll(false);

            if (botMovement != null)
            {
                botMovement.RestartMovement();
                botMovement.StopMovement(false);
            }
        }

        public void Upgrade(float number)
        {
            scale += number;
            transform.DOScale(scale, 0.3f);
            VibrationManager.Instance.HeavyVibration();
            if (scale >= 1.7f) characterCanvas.SetMonsterTarget();
            if (isPlayer)
            {
                if (scale >= 1.8f) CameraController.Instance.ChangeMonsterCam(true);
                PlayerSmashes.Instance.AddSmashes(1);
            }
        }

        public void DieCharacter()
        {
            if (_isDie)
                return;

            _isDie = true;

            characterAnimation.DecreaseAnimation();
            if (isPlayer) 
            { 
                ArenaManager.Instance.RemovePlayer();
                Debug.Log("Die");
            }

            Destroy(characterCanvas.gameObject);
            characterFight.DeactiveFight();
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
            if (_isDie)
                return;

            StopMovement(true);
            characterAnimation.DanceAnimation();
            DOVirtual.DelayedCall(2f, () => UIManager.Instance.RewardScreen(true));
        }
    }
}
