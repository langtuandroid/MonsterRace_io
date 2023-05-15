using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Core
{
    public class Finish : MonoBehaviour
    {
        #region Variables

        [SerializeField] private GameObject finishPlatform;

        #endregion

        private void Start()
        {
            LevelManager.Instance.OnLevelCompleted += ActiveFinish;
        }

        private void ActiveFinish() => finishPlatform.SetActive(true);
    }
}
