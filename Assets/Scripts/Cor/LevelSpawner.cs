using System.Collections.Generic;
using UnityEngine;

namespace BlueStellar.Cor
{
    public class LevelSpawner : MonoBehaviour
    {
        [SerializeField] List<string> levelName = new List<string>();

        Arena _arena;

        public Arena LevelArena()
        {
            return _arena; 
        }

        public void SpawnLevel(int indexLvl)
        {
            GameObject loadLevelArena = Resources.Load("Prefabs/Arenas/" + levelName[indexLvl]) as GameObject;
            GameObject levelArena = Instantiate(loadLevelArena, transform.position, transform.rotation);
            _arena = levelArena.GetComponent<Arena>();
        }
    }
}
