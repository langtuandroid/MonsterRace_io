using System.Collections.Generic;
using UnityEngine;

namespace Cor
{
    public class MemberSpawner : MonoBehaviour
    {
        [SerializeField] List<string> bots = new List<string>();

        public void CreatePlayer(Arena arena)
        {
            GameObject loadPlayer = Resources.Load("Prefabs/Player") as GameObject;
            GameObject player = Instantiate(loadPlayer, arena.GetPlayerPoint().position, arena.GetPlayerPoint().rotation);
            player.GetComponentInChildren<CharacterSettings>().SetupCollectableMonster(arena.GetCollectableMonsters()[0]);
        }

        public void CreateBots(Arena arena)
        {
            for (int i = 0; i < arena.GetPoints().Length; i++)
            {
                GameObject loadBot = Resources.Load("Prefabs/Bots/" + bots[i]) as GameObject;
                GameObject bot = Instantiate(loadBot, arena.GetPoints()[i].position, arena.GetPoints()[i].rotation);
                bot.GetComponent<BotMovement>().SetMonsterPoints(arena.GetMonsterPoints()[i]);
                bot.GetComponentInChildren<CharacterSettings>().SetupCollectableMonster(arena.GetCollectableMonsters()[i+1]);
            }
        }
    }
}
