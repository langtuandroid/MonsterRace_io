using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

namespace BlueStellar.Cor
{
    public class Coin : MonoBehaviour
    {
        Transform target;

        private void Start()
        {
            target = GameObject.Find("CoinCounter").transform;
            transform.DOScale(transform.localScale, 0.2f).From(0);
        }

        public void ToTarget()
        {
            transform.DOMove(target.position, 0.5f);
            transform.DOScale(0, 2f);
            Invoke("Deleted", 0.7f);
        }

        private void Deleted()
        {
            MoneyWallet.Instance.MoneyPlus(10);
            Destroy(gameObject);
        }
    }
}
