using System;
using UnityEngine;

namespace Core.MyPool
{
    [Serializable]
    public sealed class PoolItem
    {
        [SerializeField] private GameObject prefab;
        [SerializeField] private int size;
        
        public GameObject Prefab => prefab;
        public int Size => size;
    }
}