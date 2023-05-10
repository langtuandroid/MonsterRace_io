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
            public string[] _name;
        }

        #region Variables

        [SerializeField] List<SkinReward> currrencySkin = new List<SkinReward>();
        [SerializeField] Slider _sliderProgress;
        [SerializeField] Image chest;
        [SerializeField] Sprite closeChest;
        [SerializeField] Sprite openChest;
        [SerializeField] List<int> targetRewardChest = new List<int>();
        [SerializeField] List<int> targetRewardSkin = new List<int>();
        [SerializeField] private int smashesProgress;
        [SerializeField] RatingMenu _ratingMenu;
        [SerializeField] AnonserScreen anonserScreen;
        [SerializeField] RatingScreen ratingScreen;

        private bool isOpenChest;

        private int indexProgress;

        private PlayerCharacterSkin _playerSkin;

        #endregion

        private void Start()
        {
            LoadData();
            CheckChest();
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
            SaveData();
            return;
        }

        public void CheckRewards()
        {
            if (!isOpenChest)
            {
                if (smashesProgress >= targetRewardChest[indexProgress])
                {
                    _ratingMenu.ChangeChestReward();
                    MoneyWallet.Instance.MoneyPlus(200);
                    isOpenChest = true;
                }
            }

            if (smashesProgress >= targetRewardSkin[indexProgress])
            {
                ES3.Save("isRewardPart" + currrencySkin[indexProgress]._name[0], false);
                ES3.Save("isRewardPart" + currrencySkin[indexProgress]._name[1], false);
                ES3.Save("isRewardPart" + currrencySkin[indexProgress]._name[2], false);
                ES3.Save("isRewardPart" + currrencySkin[indexProgress]._name[3], false);
                indexProgress++;
                _playerSkin.DeactiveAllParts();
                _playerSkin.AddHeadPart(currrencySkin[indexProgress]._characterType);
                _playerSkin.AddArmsPart(currrencySkin[indexProgress]._characterType);
                _playerSkin.AddBodyPart(currrencySkin[indexProgress]._characterType);
                _playerSkin.AddLegsPart(currrencySkin[indexProgress]._characterType);
                smashesProgress = 0;
                _sliderProgress.maxValue = targetRewardSkin[indexProgress];
                _sliderProgress.value = smashesProgress;
                _ratingMenu.ChangeSkinReward();
                isOpenChest = false;
            }

            CheckChest();
            SaveData();
            ratingScreen.ActiveScreen();
        }

        public void NextSkin()
        {
            anonserScreen.DeactiveScreen();
            currrencySkin[indexProgress-1]._skin.SetActive(false);
            currrencySkin[indexProgress]._skin.SetActive(true);
        }

        private void CheckChest()
        {
            if (isOpenChest)
            {
                chest.sprite = openChest;
                return;
            }

            chest.sprite = closeChest;
        }

        #region Load&SaveData

        private void LoadData()
        {
            smashesProgress = ES3.Load("smashesProgress", smashesProgress);
            indexProgress = ES3.Load("indexProgress", indexProgress);
            isOpenChest = ES3.Load("isOpenChest", isOpenChest);
        }

        private void SaveData()
        {
            ES3.Save("smashesProgress", smashesProgress);
            ES3.Save("indexProgress", indexProgress);
            ES3.Save("isOpenChest", isOpenChest);
        }

        #endregion
    }
}
