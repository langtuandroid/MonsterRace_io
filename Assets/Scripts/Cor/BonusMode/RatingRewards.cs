using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Cor
{
    public class RatingRewards : MonoBehaviour
    {
        [System.Serializable]
        public class SkinReward
        {
            public CharacterMonsterType _characterType;
            public GameObject _skin;
        }

        #region Variables

        [SerializeField] List<SkinReward> currrencySkin = new List<SkinReward>();
        [SerializeField] Slider _sliderProgress;
        [SerializeField] List<int> targetRewardChest = new List<int>();
        [SerializeField] List<int> targetRewardSecondChest = new List<int>();
        [SerializeField] List<int> targetRewardSkin = new List<int>();
        [SerializeField] private int smashesProgress;
        [SerializeField] RatingMenu _ratingMenu;

        private bool isOpenChest;
        private bool isOpenChest2;
        private bool isOpenSkin;

        private int indexProgress;

        private PlayerCharacterSkin _playerSkin;

        #endregion

        private void Start()
        {
            LoadData();
           // ES3.Save("isRewardPart" + "Venom_Head", false);
         
            _sliderProgress.maxValue = targetRewardSkin[indexProgress];
            _sliderProgress.value = smashesProgress;
            _playerSkin = GameObject.FindObjectOfType<PlayerCharacterSkin>();
            _playerSkin.AddHeadPart(currrencySkin[indexProgress]._characterType);
            _playerSkin.AddArmsPart(currrencySkin[indexProgress]._characterType);
            _playerSkin.AddBodyPart(currrencySkin[indexProgress]._characterType);
            _playerSkin.AddLegsPart(currrencySkin[indexProgress]._characterType);
            currrencySkin[indexProgress]._skin.SetActive(true);
        }

        public void AddProgress()
        {
            smashesProgress++;
            _sliderProgress.value = smashesProgress;
            if (!isOpenChest)
            {
                if (smashesProgress >= targetRewardChest[indexProgress])
                {
                    _ratingMenu.ChangeChestReward();
                    isOpenChest = true;
                }
            }
            if (!isOpenSkin)
            {
                if (smashesProgress >= targetRewardSkin[indexProgress])
                {
                    indexProgress++;
                    _playerSkin.DeactiveAllParts();
                    _playerSkin.AddHeadPart(currrencySkin[indexProgress]._characterType);
                    _playerSkin.AddArmsPart(currrencySkin[indexProgress]._characterType);
                    _playerSkin.AddBodyPart(currrencySkin[indexProgress]._characterType);
                    _playerSkin.AddLegsPart(currrencySkin[indexProgress]._characterType);
                    isOpenSkin = true;
                }
            }
            SaveData();
        }

        #region Load&SaveData

        private void LoadData()
        {
            smashesProgress = ES3.Load("smashesProgress", smashesProgress);
            indexProgress = ES3.Load("indexProgress", indexProgress);
        }

        private void SaveData()
        {
            ES3.Save("smashesProgress", smashesProgress);
            ES3.Save("indexProgress", indexProgress);
        }

        #endregion
    }
}
