using System.Collections;
using UnityEngine;

namespace PlayKing.Cor
{
    public class SpawnedBall
    {
        CollectableBall _collectableBall;
        CharacterColorType _type;
        Vector3 _spawnPosition;
        CollectableBallsField _collectableBallsField;

        public CollectableBall GetCollectableBall()
        {
            return _collectableBall;
        }

        public CharacterColorType GetSpawnedBallType()
        {
            return _type;
        }

        public Vector3 SpawnPosition()
        {
            return _spawnPosition;
        }

        public void SetSpawnedBall(CollectableBall ball, Vector3 pos, CollectableBallsField collectableBallsField)
        {
            _collectableBall = ball;
            _type = _collectableBall.Type();
            _spawnPosition = pos;
            _collectableBallsField = collectableBallsField;
        }

        public void SetNewSpawnedBall(CollectableBall collectableBall)
        {
            _collectableBall = collectableBall;
            _type = _collectableBall.Type();
        }

        public void ClearSpawnedBall()
        {
            _collectableBall = null;
        }

        public IEnumerator NewCollactable()
        {
            yield return new WaitForSeconds(1.5f);

            _collectableBallsField.GenerateRemovedBall(this);
        }
    }
}
