using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PlayKing.Cor
{
    public class RewardMoney : MonoBehaviour
    {
        [SerializeField] ButtonManager buttonManager;
        [SerializeField] GameObject prefabMoney;
        [SerializeField] Transform[] pointSpawn;
        [SerializeField] GameObject button;
        [SerializeField] int rewardMoney;
        [SerializeField] List<Coin> coins = new List<Coin>();
        private int index;

        public void SpawnMoney()
        {
            buttonManager.NextLevel();
            button.SetActive(false);
            //StopAllCoroutines();
            //StartCoroutine(IE_Spawn());
            //StartCoroutine(IE_Win());
        }

        private IEnumerator IE_Spawn()
        {
            for(int i = 0; i < rewardMoney; i += 10)
            {
                GameObject newMoney = Instantiate(prefabMoney, pointSpawn[index].position, Quaternion.identity);
                newMoney.transform.parent = pointSpawn[index];
                coins.Add(newMoney.GetComponent<Coin>());
                index++;
                if (index >= 10)
                {
                    StartCoroutine(IE_Target());
                    index = 0;
                }
                yield return new WaitForSeconds(0.15f);
            }
        }

        private IEnumerator IE_Win()
        {
            yield return new WaitForSeconds(3.2f);

            buttonManager.NextLevel();
        }

        private IEnumerator IE_Target()
        {
            foreach (var i in coins)
            {
                i.ToTarget();
                yield return new WaitForSeconds(0.15f);
            }
        }
    }
}
