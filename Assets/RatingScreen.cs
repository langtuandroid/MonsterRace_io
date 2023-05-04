using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Cor
{
    public class RatingScreen : MonoBehaviour
    {
        public void ActiveScreen()
        {

        }

        public void DeactiveScreen()
        {
            LevelManager.Instance.LevelStart();
            LevelManager.Instance.LevelFight();
            gameObject.SetActive(false);
        }
    }
}
