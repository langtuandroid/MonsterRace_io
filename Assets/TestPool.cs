using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cor.MyPool;

namespace Cor {
    public class TestPool : MonoBehaviour
    {
        [SerializeField] List<CollectableBall> collectableBalls = new List<CollectableBall>();
        [SerializeField] GameObject prefab;

        private void Update()
        {
            if (Input.GetKeyDown("s"))
            {
                CollectableBall collectableBall = NightPool.Spawn(prefab,transform.position, transform.rotation).GetComponent<CollectableBall>();
                collectableBalls.Add(collectableBall);
            }

            if (Input.GetKeyDown("a"))
            {
                NightPool.Despawn(collectableBalls[0]);
                collectableBalls.RemoveAt(0);
            }
        }
    }
}
