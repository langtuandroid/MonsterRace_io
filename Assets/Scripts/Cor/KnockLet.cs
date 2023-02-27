using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

namespace BlueStellar.Cor
{
    public class KnockLet : MonoBehaviour
    {
        [SerializeField] private float speedRotate;

        private void Start()
        {
            LevelController.Instance.OnLevelStart.AddListener(ActivityLet);    
        }

        private void ActivityLet()
        {
            transform.DORotate(new Vector3(0f, 359f, 0f), speedRotate, RotateMode.WorldAxisAdd).SetLoops(-1).SetEase(Ease.Linear);
        }

        private void OnTriggerEnter(Collider other)
        {
            if(other.gameObject.tag == "Character")
            {
                if(other.GetComponent<Character>() != null)
                    other.GetComponent<Character>().KnockCharacter(transform);
            }
        }
    }
}
