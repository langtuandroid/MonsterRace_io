using UnityEngine;

namespace Core
{
    public class SpawnedBall
    {
        #region Variables

        private CollectableBall _collectableBall;
        private CharacterColorType _type;
        private Vector3 _spawnPosition;

        #endregion

        public CollectableBall GetCollectableBall()
        {
            return _collectableBall;
        }

        public CharacterColorType GetSpawnedBallType()
        {
            return _type;
        }

        public Vector3 GetSpawnPosition()
        {
            return _spawnPosition;
        }

        public void SetSpawnedBall(CollectableBall ball, Vector3 pos, CollectableBallsField collectableBallsField)
        {
            _collectableBall = ball;
            _type = _collectableBall.Type();
            _spawnPosition = pos;
        }

        public void SetNewSpawnedBall(CollectableBall collectableBall)
        {
            _collectableBall = collectableBall;
            _type = _collectableBall.Type();
        }

        public void ClearSpawnedBall() =>  _collectableBall = null;
    }
}
