using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace BlueStellar.Cor
{
    public class CollectableBallsField : MonoBehaviour
    {
        [System.Serializable]
        public class BallType
        {
            public GameObject ballPrefab;
            public CharacterColorType type;
        }

        #region Variables

        [Header("BallTypes")]
        [SerializeField] List<BallType> ballTypes = new List<BallType>();

        [Space]
        [Header("FieldPlacement")]
        [SerializeField] Transform[] points;
        [SerializeField] private int typesAmmount;
        [SerializeField] private int length;

        [Space]
        [Header("TimerResetBall")]
        [SerializeField] private float timeToResetBall;
        [SerializeField] private float timer;

        [Space]
        [Header("Debug_AllBalls")]
        [SerializeField] List<CollectableBall> allBalls = new List<CollectableBall>();
        [SerializeField] private int maxBalls;

        private Vector3 _startPoint;
        private Vector3 _position;

        private List<SpawnedBall> spawnedBalls = new List<SpawnedBall>();
        private List<SpawnedBall> respawnBalls = new List<SpawnedBall>();

        #endregion

        public List<Vector3> ListTypeBalls(CharacterColorType colorType)
        {
            List<Vector3> balls = new List<Vector3>();
            switch (colorType)
            {
                case CharacterColorType.Blue:
                    foreach (var i in spawnedBalls)
                    {
                        if (i.GetSpawnedBallType() == colorType)
                            balls.Add(i.SpawnPosition());
                    }
                    return balls;
                case CharacterColorType.Yellow:
                    foreach (var i in spawnedBalls)
                    {
                        if (i.GetSpawnedBallType() == colorType)
                            balls.Add(i.SpawnPosition());
                    }
                    return balls;
                case CharacterColorType.Green:
                    foreach (var i in spawnedBalls)
                    {
                        if (i.GetSpawnedBallType() == colorType)
                            balls.Add(i.SpawnPosition());
                    }
                    return balls;
                case CharacterColorType.Violet:
                    foreach (var i in spawnedBalls)
                    {
                        if (i.GetSpawnedBallType() == colorType)
                            balls.Add(i.SpawnPosition());
                    }
                    return balls;
                case CharacterColorType.Purple:
                    foreach (var i in spawnedBalls)
                    {
                        if (i.GetSpawnedBallType() == colorType)
                            balls.Add(i.SpawnPosition());
                    }
                    return balls;
                case CharacterColorType.Red:
                    foreach (var i in spawnedBalls)
                    {
                        if (i.GetSpawnedBallType() == colorType)
                            balls.Add(i.SpawnPosition());
                    }
                    return balls;
            }
            return null;
        }

        public void SetPlacementSettings(Arena _arena)
        {
            points = _arena.GetBallsPoints();
            typesAmmount = _arena.GetMaxTypes();
            length = _arena.GetAmmountBalls();
            maxBalls = length;
            GO();
        }

        public void GO()
        { 
            BallsPlacement();
        }

        private void Update()
        {
            ResetBall();
        }

        #region GenerateBalls

        public void RemoveBall(CollectableBall collectableBall)
        {
            foreach (var i in spawnedBalls)
            {
                if (collectableBall == i.GetCollectableBall())
                {
                    i.ClearSpawnedBall();
                    allBalls.Remove(collectableBall);
                    respawnBalls.Add(i);
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
                        respawnBalls.Add(spawnedBalls[i]);
                    }
                }
            }
        }

        public void GenerateRemovedBall(SpawnedBall spawnedBall)
        {
            if (ballTypes.Count == 0)
                return;

            BallType ballType = ballTypes[Random.Range(0, typesAmmount)];
            GameObject createdBall = Instantiate(ballType.ballPrefab, spawnedBall.SpawnPosition(),
                Quaternion.identity);

            CollectableBall ball = createdBall.GetComponent<CollectableBall>();

            createdBall.transform.parent = transform;
            createdBall.transform.position = spawnedBall.SpawnPosition();
            spawnedBall.SetNewSpawnedBall(ball);
            allBalls.Add(ball);
            respawnBalls.Remove(spawnedBall);
        }

        private void ResetBall()
        {
            if (allBalls.Count >= maxBalls)
                return;
            
            timer += Time.deltaTime;

            if (timer >= timeToResetBall)
            {
                if (respawnBalls.Count == 0)
                {
                    timer = 0f;
                    return;
                }

                GenerateRemovedBall(respawnBalls[0]);

                timer = 0f;
            }
        }

        #endregion

        #region Placement

        private void BallsPlacement()
        {
            for (int i = 0; i < length; i++)
            {
                _position = new Vector3(points[i].position.x, transform.position.y, points[i].position.z);

                FirstSpawn(_position);
            }

            //for(int i = 0; i < 50; i++)
            //{
            //   spawnedBalls[i].GetCollectableBall().gameObject.SetActive(true);
            //}

           // StartCoroutine(IE_Step());
        }

        private void FirstSpawn(Vector3 position)
        {
            BallType ballType = ballTypes[Random.Range(0, typesAmmount)];

            GameObject newCollectableBall = Instantiate(ballType.ballPrefab,
             position, ballType.ballPrefab.transform.rotation);

            newCollectableBall.transform.parent = transform;
            CollectableBall ball = newCollectableBall.GetComponent<CollectableBall>();

            SpawnedBall spawnedBall = new SpawnedBall();
            spawnedBall.SetSpawnedBall(ball, position, this);
            spawnedBalls.Add(spawnedBall);
            allBalls.Add(ball);
            //newCollectableBall.SetActive(false);
        }

        private IEnumerator IE_Step()
        {
            for(int i = 50; i < spawnedBalls.Count; i++)
            {
                spawnedBalls[i].GetCollectableBall().gameObject.SetActive(true);
                yield return new WaitForSeconds(0f);
            }
        }

        #endregion
    }
}
