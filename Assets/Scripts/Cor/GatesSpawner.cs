using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace BlueStellar.Cor
{
    public class GatesSpawner : MonoBehaviour
    {
        #region Variables

        [SerializeField] GameObject prefabGates;
        [SerializeField] List<Transform> pointsSpawn = new List<Transform>();
        [SerializeField] List<GatesType> gatesTypes = new List<GatesType>();
        [SerializeField] private int minGates;
        [SerializeField] private int maxGates;
        [SerializeField] private int ammountGates;

        List<Gates> currencyGates = new List<Gates>();

        #endregion

        public void SetupGatesPoints(Arena arena)
        {
            gatesTypes.AddRange(arena.GetGateTypes().ToArray());
            pointsSpawn.AddRange(arena.GetGatesPoints().ToArray());
            LevelController.Instance.OnLevelStart.AddListener(SpawnGate);
        }

        public void RemoveGate(Gates gates)
        {
            currencyGates.Remove(gates);
            CheckGates();
        }

        private void SpawnGate()
        {
            ammountGates = Random.Range(minGates, maxGates);

            List<Transform> points = new List<Transform>();
            points.AddRange(pointsSpawn.ToArray());

            for(int i = 0; i < ammountGates; i++)
            {
                int randomPoint = Random.Range(0, points.Count);
                int randomType = Random.Range(0, gatesTypes.Count);

                GameObject newGate = Instantiate(prefabGates, points[randomPoint].position, points[randomPoint].rotation);
                newGate.transform.parent = points[randomPoint];
                points.Remove(points[randomPoint]);
                
                Gates gates = newGate.GetComponent<Gates>();
                gates.SetGatesSettings(this, gatesTypes[randomType]);
                if (gatesTypes[randomType] == GatesType.Multyplying) gatesTypes.RemoveAt((int)gatesTypes[randomType]);
                currencyGates.Add(gates);
            }
        }

        private void CheckGates()
        {
            if (currencyGates.Count > 0)
                return;

            StopAllCoroutines();
            StartCoroutine(IE_GenerateNewGates());
        }

        private IEnumerator IE_GenerateNewGates()
        {
            yield return new WaitForSeconds(8f);

            SpawnGate();
        }
    }
}
