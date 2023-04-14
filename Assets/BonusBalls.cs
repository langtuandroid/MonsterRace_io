using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

namespace Cor
{
    public class BonusBalls : MonoBehaviour
    {
        #region Variables

        [SerializeField] Text textCounter;
        [SerializeField] GameObject prefab;
        [SerializeField] private int ammountBonus;

        private CollectableBallsField _collectableBallsField;
        private PlayerMovement _playerMovement;
        private StackBalls _stackBalls;

        #endregion

        private void Start()
        {
            _collectableBallsField = GameObject.FindObjectOfType<CollectableBallsField>();
            _playerMovement = GameObject.FindObjectOfType<PlayerMovement>();
            _stackBalls = _playerMovement.GetComponentInChildren<StackBalls>();
            textCounter.text = "+" + ammountBonus + "BALLS";
        }

        public void ClaimBonus()
        {
            float timer = 0;

            for (int i = 0; i < ammountBonus; i++)
            {
                GameObject ball = Instantiate(prefab.gameObject, transform.position, transform.rotation);
                _stackBalls.AddCollectableBall(ball.GetComponent<CollectableBall>(), false);
                ball.SetActive(false);
                DOVirtual.DelayedCall(timer, () => ball.SetActive(true));
                timer += 0.03f;
            }
            //LevelManager.Instance.LevelStart();
        }
    }
}
