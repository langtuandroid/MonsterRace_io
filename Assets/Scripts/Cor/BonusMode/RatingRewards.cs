using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Cor
{
    public class RatingRewards : MonoBehaviour
    {
        #region Variables

        [SerializeField] Slider _sliderProgress;
        [SerializeField] List<int> targetRewardChest = new List<int>();
        [SerializeField] List<int> targetRewardSecondChest = new List<int>();
        [SerializeField] List<int> targetRewardSkin = new List<int>();
        [SerializeField] private int smashesProgress;

        [SerializeField] RatingMenu _ratingMenu;

        private int indexProgress;

        #endregion

        public void AddProgress()
        {
            smashesProgress++;
            _sliderProgress.value = smashesProgress;
            if(smashesProgress == targetRewardChest[indexProgress])
            {
                _ratingMenu.ChangeChestReward();
            }
        }
    }
}
