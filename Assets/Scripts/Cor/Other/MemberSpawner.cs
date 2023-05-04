using System.Collections.Generic;
using UnityEngine;

namespace Cor
{
    public class MemberSpawner : MonoBehaviour
    {
        #region Variables

        [SerializeField] private string playerName;
        [SerializeField] List<string> bots = new List<string>();

        #endregion

        public void CreatePlayer(Arena arena)
        {
            GameObject loadPlayer = Resources.Load("Prefabs/Characters/" + playerName) as GameObject;
            GameObject player = Instantiate(loadPlayer, arena.GetPlayerPoint().position, arena.GetPlayerPoint().rotation);
            if(player.GetComponentInChildren<CharacterSettings>() != null)
                player.GetComponentInChildren<CharacterSettings>().SetupCollectableMonster(arena.GetCollectableMonsters()[0]);
        }

        public void CreateBots(Arena arena)
        {
            for (int i = 0; i < arena.GetPoints().Length; i++)
            {
                GameObject loadBot = Resources.Load("Prefabs/Characters/Bots/" + bots[i]) as GameObject;
                GameObject bot = Instantiate(loadBot, arena.GetPoints()[i].position, arena.GetPoints()[i].rotation);
                if (bot.GetComponentInChildren<BotMovement>() != null)
                    bot.GetComponent<BotMovement>().SetMonsterPoints(arena.GetMonsterPoints()[i]);
                if (bot.GetComponentInChildren<CharacterSettings>() != null)
                    bot.GetComponentInChildren<CharacterSettings>().SetupCollectableMonster(arena.GetCollectableMonsters()[i+1]);
            }
        }
    }
}
