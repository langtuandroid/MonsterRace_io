using System.Collections.Generic;
using UnityEngine;

namespace BlueStellar.Cor
{
    public class GatesSpawner : MonoBehaviour
    {
        [SerializeField] GameObject prefabGates;
        [SerializeField] List<Transform> pointsSpawn = new List<Transform>();
        [SerializeField] List<GatesType> gatesTypes = new List<GatesType>();
        [SerializeField] private int minGates;
        [SerializeField] private int maxGates;
        [SerializeField] private int ammountGates;

        private void Start()
        {
            LevelController.Instance.OnLevelStart.AddListener(SpawnGate);
        }

        private void SpawnGate()
        {
            if (LevelController.Instance.LvlNumber() == 1)
                return;

            ammountGates = Random.Range(minGates, maxGates);
            for(int i = 0; i < ammountGates; i++)
            {
                int randomPoint = Random.Range(0, pointsSpawn.Count);
                int randomType = Random.Range(0, gatesTypes.Count);
                GameObject newGate = Instantiate(prefabGates, pointsSpawn[randomPoint].position, pointsSpawn[randomPoint].rotation);
                pointsSpawn.Remove(pointsSpawn[randomPoint]);
                Gates gates = newGate.GetComponent<Gates>();
                gates.SetGatesSettings(gatesTypes[randomType]);
            }
        }
    }
}
