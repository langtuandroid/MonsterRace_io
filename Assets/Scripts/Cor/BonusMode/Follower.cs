using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

namespace Cor
{
    public class Follower : MonoBehaviour
    {
        [SerializeField] RatingMember ratingMember;

        private void FixedUpdate()
        {
            if(ratingMember.GetRating() == 20)
            {
                transform.DOMoveY(2254f, 0.8f);
            }
        }
    }
}
