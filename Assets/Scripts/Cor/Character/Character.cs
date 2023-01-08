using UnityEngine;

public enum CharacterColorType
{
    Blue,
    Green,
    Yellow
}

namespace PlayKing.Cor
{
    public class Character : MonoBehaviour
    {
        [SerializeField] CharacterColorType _characterColorType;

        StackBalls _stackBalls;
        BallsMonster _ballsMoster;

        private void Start()
        {
            _stackBalls = GetComponent<StackBalls>();
        }

        public void KnockCharacter()
        {

        }

        private void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("Ball"))
            {
                CollectableBall _ball = other.GetComponent<CollectableBall>();
                if (!_ball.IsTrueCharacter(_characterColorType))
                    return;

                _stackBalls.AddCollectableBall(_ball);
            }
        }

        private void OnTriggerStay(Collider other)
        {
            if (other.CompareTag("MonsterFields"))
            {
                _ballsMoster = other.GetComponentInParent<BallsMonster>();
                if (_ballsMoster.IsTrueCharacter(_characterColorType))
                {
                    _stackBalls.UnstackBalls(_ballsMoster);
                }
            }
        }
    }
}
