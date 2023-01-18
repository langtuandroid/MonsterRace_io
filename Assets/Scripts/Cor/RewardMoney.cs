using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PlayKing.Cor
{
    public class RewardMoney : MonoBehaviour
    {
        [SerializeField] GameObject prefabMoney;
        [SerializeField] Transform[] pointSpawn;
        [SerializeField] GameObject button;
        [SerializeField] int rewardMoney;
        List<Coin> coins = new List<Coin>();
        int index;

        public void SpawnMoney()
        {
            UIManager.Instance.WinScreen(true);
            button.SetActive(false);
           StartCoroutine(IE_Spawn());
        }

        private void FixedUpdate()
        {
            if(index >= 10)
            {
                StartCoroutine(IE_Target());
                index = 0;
            }
        }

        private IEnumerator IE_Spawn()
        {
            for(int i = 0; i < rewardMoney; i += 10)
            {
                GameObject newMoney = Instantiate(prefabMoney, pointSpawn[index].position, Quaternion.identity);
                newMoney.transform.parent = pointSpawn[index];
                coins.Add(newMoney.GetComponent<Coin>());
                index++;
                yield return new WaitForSeconds(0.15f);
            }
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
