using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Cor
{
    public class Finish : MonoBehaviour
    {
        #region Variables

        [SerializeField] GameObject finishPlatform;

        #endregion

        private void Start()
        {
            LevelManager.Instance.OnLevelCompleted += ActiveFinish;
        }

        private void ActiveFinish() => finishPlatform.SetActive(true);
    }
}
