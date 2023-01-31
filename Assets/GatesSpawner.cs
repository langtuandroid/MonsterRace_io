using System.Collections.Generic;
using UnityEngine;

namespace BlueStellar.Cor
{
    public class GatesSpawner : MonoBehaviour
    {
        [SerializeField] GameObject prefabGates;
        [SerializeField] List<Transform> pointsSpawn = new List<Transform>();
        [SerializeField] private int ammountGates;

        private void Start()
        {
            LevelController.Instance.OnLevelStart.AddListener(SpawnGate);
        }

        private void SpawnGate()
        {
            ammountGates = Random.Range(1, 4);
            for(int i = 0; i < ammountGates; i++)
            {
                int randomPoint = Random.Range(0, pointsSpawn.Count);
                GameObject newGate = Instantiate(prefabGates, pointsSpawn[randomPoint].position, pointsSpawn[randomPoint].rotation);
                pointsSpawn.Remove(pointsSpawn[randomPoint]);
                Gates gates = newGate.GetComponent<Gates>();
                gates.SetGatesSettings(GatesType.Negative);
            }
        }
    }
}
