using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PlayKing.Cor
{
    public class CollectableBallsField : MonoBehaviour
    {
        [System.Serializable]
        public class BallType
        {
            public GameObject ballPrefab;
            public CharacterColorType type;
        }

        [Header("BallTypes")]
        [SerializeField] List<BallType> ballTypes = new List<BallType>();

        [Header("FieldPlacement")]
        [SerializeField] private int length;
        [SerializeField] private int line;
        [SerializeField] private float xOrder;
        [SerializeField] private float xPosition;
        [SerializeField] private float zPosition;
        [SerializeField] private float form;

        [Header("TimerResetBall")]
        [SerializeField] private float timeToResetBall;
        [SerializeField] private float timer;

        private Vector3 startPoint;
        private Vector3 position;

        private List<SpawnedBall> spawnedBalls = new List<SpawnedBall>();

        public List<Vector3> ListTypeBalls(CharacterColorType colorType)
        {
            List<Vector3> balls = new List<Vector3>();
            switch (colorType)
            {
                case CharacterColorType.Blue:
                    foreach (var i in spawnedBalls)
                    {
                        if (i.GetSpawnedBallType() == colorType)
                        {
                            balls.Add(i.SpawnPosition());
                        }
                    }
                    return balls;
                case CharacterColorType.Yellow:
                    foreach (var i in spawnedBalls)
                    {
                        if (i.GetSpawnedBallType() == colorType)
                        {
                            balls.Add(i.SpawnPosition());
                        }
                    }
                    return balls;
                case CharacterColorType.Green:
                    foreach (var i in spawnedBalls)
                    {
                        if (i.GetSpawnedBallType() == colorType)
                        {
                            balls.Add(i.SpawnPosition());
                        }
                    }
                    return balls;
                case CharacterColorType.Violet:
                    foreach (var i in spawnedBalls)
                    {
                        if (i.GetSpawnedBallType() == colorType)
                        {
                            balls.Add(i.SpawnPosition());
                        }
                    }
                    return balls;
                case CharacterColorType.Purple:
                    foreach (var i in spawnedBalls)
                    {
                        if (i.GetSpawnedBallType() == colorType)
                        {
                            balls.Add(i.SpawnPosition());
                        }
                    }
                    return balls;
                case CharacterColorType.Red:
                    foreach (var i in spawnedBalls)
                    {
                        if (i.GetSpawnedBallType() == colorType)
                        {
                            balls.Add(i.SpawnPosition());
                        }
                    }
                    return balls;
            }
            return null;
        }

        void Start()
        {
            SetStartPos();
            BallsPlacement();
        }

        public void RemoveBall(CollectableBall collectableBall)
        {
            foreach (var i in spawnedBalls)
            {
                if (collectableBall == i.GetCollectableBall())
                {
                    i.ClearSpawnedBall();
                    StartCoroutine(i.NewCollactable(1.5f));
                }
            }
        }

        public void RemoveSpawnedBall(CharacterColorType _characterColorType)
        {
            for (int i = 0; i < ballTypes.Count; i++)
            {
                if(ballTypes[i].type == _characterColorType)
                {
                    ballTypes.Remove(ballTypes[i]);
                }
            }

            for (int i = 0; i < spawnedBalls.Count; i++)
            {
                if(spawnedBalls[i].GetSpawnedBallType() == _characterColorType)
                {
                    if (spawnedBalls[i].GetCollectableBall() != null)
                    {
                        Destroy(spawnedBalls[i].GetCollectableBall().gameObject);
                        spawnedBalls[i].ClearSpawnedBall();
                        if (ballTypes.Count == 0)
                            return;

                        float randomTime = Random.Range(2f, 6f);
                        StartCoroutine(spawnedBalls[i].NewCollactable(randomTime));
                    }
                }
            }
        }

        public void GenerateRemovedBall(SpawnedBall spawnedBall)
        {
            BallType ballType = ballTypes[Random.Range(0, ballTypes.Count)];
            GameObject createdBall = Instantiate(ballType.ballPrefab, spawnedBall.SpawnPosition(),
                Quaternion.identity);

            createdBall.transform.parent = transform;
            createdBall.transform.position = spawnedBall.SpawnPosition();
            spawnedBall.SetNewSpawnedBall(createdBall.GetComponent<CollectableBall>());
        }

        private void SetStartPos()
        {
            startPoint = transform.position;
            zPosition = transform.position.z;
            xPosition = transform.position.x;
        }

        private void BallsPlacement()
        {
            for (int i = 0; i < length; i++)
            {
                xOrder += form;

                if (i % line == 0)
                {
                    zPosition -= 1f;
                    xOrder = 0;
                    position = new Vector3(xPosition, startPoint.y, zPosition);
                }
                else
                {
                    position = new Vector3(xPosition + xOrder, startPoint.y, zPosition);
                }

                BallType ballType = ballTypes[Random.Range(0, ballTypes.Count)];

                GameObject newCollectableBall = Instantiate(ballType.ballPrefab,
                 position, ballType.ballPrefab.transform.rotation);

                newCollectableBall.transform.parent = transform;

                SpawnedBall spawnedBall = new SpawnedBall();
                spawnedBall.SetSpawnedBall(newCollectableBall.GetComponent<CollectableBall>(), position, this);
                spawnedBalls.Add(spawnedBall);
            }
        }
    }
}
