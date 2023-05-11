using System.Collections.Generic;
using UnityEngine;

namespace Cor
{
    public class LevelSpawner : MonoBehaviour
    {
        #region Variables

        [SerializeField] List<string> levelName = new List<string>();

        [SerializeField] private Arena _arena;
        [SerializeField] private bool isDebug;

        #endregion

        public Arena LevelArena()
        {
            return _arena; 
        }

        public void SpawnLevel(int indexLvl)
        {
            if (isDebug)
                return;

            GameObject loadLevelArena = Resources.Load("Prefabs/Arenas/" + levelName[indexLvl]) as GameObject;
            GameObject levelArena = Instantiate(loadLevelArena, transform.position, transform.rotation);
            _arena = levelArena.GetComponent<Arena>();
        }
    }
}
