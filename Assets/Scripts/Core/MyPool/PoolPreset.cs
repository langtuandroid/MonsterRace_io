using System.Collections.Generic;
using UnityEngine;

namespace Core.MyPool
{
    [CreateAssetMenu(menuName = "Source/Pool/PoolPreset", fileName = "PoolPreset", order = 0)]
    public class PoolPreset : ScriptableObject
    {
        [SerializeField] private string poolName;
        [SerializeField] private List<PoolItem> poolItems = new List<PoolItem>();

        public IReadOnlyList<PoolItem> PoolItems => poolItems;

        public string GetName()
        {
            return poolName;
        }
    }
}