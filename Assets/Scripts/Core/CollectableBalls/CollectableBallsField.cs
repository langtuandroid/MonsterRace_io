using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Core.MyPool;

namespace Core
{
    public class CollectableBallsField : MonoBehaviour
    {
        #region Variables

        [Header("BallTypes")]
        [SerializeField] private List<BallType> ballTypes = new List<BallType>();

        [Space]
        [Header("FieldPlacement")]
        [SerializeField] private Transform[] points;
        [SerializeField] private int length;

        [Space]
        [Header("TimerResetBall")]
        [SerializeField] private float timeToResetBall;
        [SerializeField] private float timer;

        [Space]
        [Header("Debug_AllBalls")]
        [SerializeField] private List<CollectableBall> allBalls = new List<CollectableBall>();
        [SerializeField] private int maxBalls;

        [Space]
        [Header("Pools")]
        [SerializeField] private List<Pool> pools = new List<Pool>();

        private Vector3 _position;
        private List<SpawnedBall> _spawnBalls = new List<SpawnedBall>();
        private List<SpawnedBall> _respawnBalls = new List<SpawnedBall>();

        #endregion

        public List<Vector3> GetListTypeBalls(CharacterColorType colorType)
        {
            List<Vector3> balls = new List<Vector3>();
            
            foreach (var i in _spawnBalls)
            {
                if (i.GetSpawnedBallType() == colorType)
                    balls.Add(i.GetSpawnPosition());
            }
            
            return balls;
        }
        
        private void Start()
        {
            foreach(var i in GameObject.FindObjectsOfType<Pool>())
            {
                pools.Add(i);
            }
 
            BallsPlacement();
        }
        
        private void Update()
        {
            ResetBall();
        }

        #region PlacementBalls

        public void SetPlacementSettings(Arena arena)
        {
            ballTypes.AddRange(arena.GetBallTypes().ToArray());
            points = arena.GetBallsPoints();
            length = arena.GetCountBalls();
            maxBalls = length;
        }
        
        private void BallsPlacement()
        {
            for (var i = 0; i < length; i++)
            {
                _position = new Vector3(points[i].position.x, points[i].position.y, points[i].position.z);

                FirstSpawn(_position);
            }

            for (var i = 0; i < 80; i++)
            {
                _spawnBalls[i].GetCollectableBall().gameObject.SetActive(true);
            }

            StartCoroutine(IE_Step());
        }

        private void FirstSpawn(Vector3 position)
        {
            BallType ballType = ballTypes[Random.Range(0, ballTypes.Count)];

            CollectableBall newCollectableBall = NightPool.Spawn(ballType.ballPrefab,
            position, ballType.ballPrefab.transform.rotation);
            newCollectableBall.transform.parent = transform;

            SpawnedBall spawnedBall = new SpawnedBall();
            spawnedBall.SetSpawnedBall(newCollectableBall, position, this);
            _spawnBalls.Add(spawnedBall);
            allBalls.Add(newCollectableBall);
            newCollectableBall.gameObject.SetActive(false);
        }

        private IEnumerator IE_Step()
        {
            for (var i = 80; i < _spawnBalls.Count; i += 5)
            {
                _spawnBalls[i].GetCollectableBall().gameObject.SetActive(true);
                if (_spawnBalls[i + 1] != null)
                    _spawnBalls[i + 1].GetCollectableBall().gameObject.SetActive(true);
                if (i + 2 < _spawnBalls.Count)
                    _spawnBalls[i + 2].GetCollectableBall().gameObject.SetActive(true);
                if (i + 3 < _spawnBalls.Count)
                    _spawnBalls[i + 3].GetCollectableBall().gameObject.SetActive(true);
                if (i + 4 < _spawnBalls.Count)
                    _spawnBalls[i + 4].GetCollectableBall().gameObject.SetActive(true);
                yield return new WaitForSeconds(0f);
            }
        }

        #endregion
        
        #region GenerateBalls

        public void RemoveBall(CollectableBall collectableBall)
        {
            foreach (var i in _spawnBalls)
            {
                if (collectableBall == i.GetCollectableBall())
                {
                    i.ClearSpawnedBall();
                    allBalls.Remove(collectableBall);
                    _respawnBalls.Add(i);
                }
            }
        }

        public void RemoveSpawnedBall(CharacterColorType characterColorType)
        {
            for (var i = 0; i < ballTypes.Count; i++)
            {
                if(ballTypes[i].type == characterColorType)
                {
                    ballTypes.Remove(ballTypes[i]);
                }
            }

            foreach (var i in _spawnBalls)
            {
                if(i.GetSpawnedBallType() == characterColorType)
                {
                    if (i.GetCollectableBall() != null)
                    {
                        NightPool.Despawn(i.GetCollectableBall().gameObject);
                        i.ClearSpawnedBall();
                        if (ballTypes.Count == 0)
                            return;
                        _respawnBalls.Add(i);
                    }
                }
            }
        }

        private void GenerateRemovedBall(SpawnedBall spawnedBall)
        {
            if (ballTypes.Count == 0)
                return;

            BallType ballType = ballTypes[Random.Range(0, ballTypes.Count)];
            CollectableBall createdBall = NightPool.Spawn(ballType.ballPrefab, spawnedBall.GetSpawnPosition(),
                Quaternion.identity);
            
            createdBall.transform.parent = transform;
            createdBall.transform.position = spawnedBall.GetSpawnPosition();
            spawnedBall.SetNewSpawnedBall(createdBall);
            allBalls.Add(createdBall);
            _respawnBalls.Remove(spawnedBall);
        }

        private void ResetBall()
        {
            if (allBalls.Count >= maxBalls)
                return;
            
            timer += Time.deltaTime;

            if (timer >= timeToResetBall)
            {
                if (_respawnBalls.Count == 0)
                {
                    timer = 0f;
                    return;
                }

                GenerateRemovedBall(_respawnBalls[0]);

                timer = 0f;
            }
        }

        #endregion
    }

    [System.Serializable]
    public class BallType
    {
        public CollectableBall ballPrefab;
        public CharacterColorType type;
    }
}
