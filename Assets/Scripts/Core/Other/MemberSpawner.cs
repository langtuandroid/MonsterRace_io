using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

namespace Core
{
    public class MemberSpawner : MonoBehaviour
    {
        #region Variables
        
        [Header("Members")]
        [SerializeField] private string playerName;
        [SerializeField] private List<string> bots = new List<string>();

        [Space] 
        [SerializeField] private SkinsController skinsController;
        [SerializeField] private Leaderboard leaderboard;
        
        #endregion

        public void CreatePlayer(Arena arena)
        {
            GameObject loadPlayer = Resources.Load("Prefabs/Characters/" + playerName) as GameObject;
            GameObject player = Instantiate(loadPlayer, arena.GetPlayerPoint().position, arena.GetPlayerPoint().rotation);
            if (LevelManager.Instance.GetGameMode() == GameModeType.Bonus)
                return;
            CharacterSettings characterSettings = player.GetComponentInChildren<CharacterSettings>();
            characterSettings.SetupSkinController(skinsController);
            characterSettings.SetLeaderborad(leaderboard);
            characterSettings.SetCollectableMonster(arena.GetCollectableMonsters()[0]);
        }

        public void CreateBots(Arena arena)
        {
            for (int i = 0; i < arena.GetPoints().Length; i++)
            {
                GameObject loadBot = Resources.Load("Prefabs/Characters/Bots/" + bots[i]) as GameObject;
                GameObject bot = Instantiate(loadBot, arena.GetPoints()[i].position, arena.GetPoints()[i].rotation);
                if (LevelManager.Instance.GetGameMode() == GameModeType.Bonus)
                    return;
                bot.GetComponent<BotMovement>().SetMonsterPoints(arena.GetMonsterPoints()[i]); 
                CharacterSettings characterSettings = bot.GetComponentInChildren<CharacterSettings>();
                characterSettings.SetupSkinController(skinsController);
                characterSettings.SetLeaderborad(leaderboard);
                characterSettings.SetCollectableMonster(arena.GetCollectableMonsters()[i + 1]);
            }
        }
    }
}
