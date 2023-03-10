using System.Collections.Generic;
using UnityEngine;

namespace BlueStellar.Cor {
    public class MemberSpawner : MonoBehaviour
    {
        [SerializeField] List<string> bots = new List<string>();

        public void CreatePlayer(Transform point)
        {
            GameObject loadPlayer = Resources.Load("Prefabs/Player") as GameObject;
            GameObject player = Instantiate(loadPlayer, point.position, point.rotation);
        }

        public void CreateBots(Transform[] points, Transform[] monsterPoints)
        {
            for (int i = 0; i < points.Length; i++)
            {
                GameObject loadBot = Resources.Load("Prefabs/Bots/" + bots[i]) as GameObject;
                GameObject bot = Instantiate(loadBot, points[i].position, points[i].rotation);
                bot.GetComponent<BotMovement>().SetMonsterPoints(monsterPoints[i], monsterPoints[i]);
            }
        }
    }
}
