using UnityEngine;

namespace Core.MyPool
{
    public class NightPoolEntry : MonoBehaviour
    {
        [SerializeField] private PoolPreset _poolPreset;

        public void SetupPool(PoolPreset poolPreset)
        {
            _poolPreset = poolPreset;
            NightPool.InstallPoolItems(_poolPreset);
        }

        private void OnDestroy()
        {
            NightPool.Reset();
        }
    }
}