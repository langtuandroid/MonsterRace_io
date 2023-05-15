using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;

namespace Core
{
    public class RatingRewards : MonoBehaviour
    {
        [System.Serializable]
        public class SkinReward
        {
            public CharacterMonsterType characterType;
            public GameObject skin;
            public string[] name;
        }

        #region Variables

        [SerializeField] private List<SkinReward> currrencySkin = new List<SkinReward>();
        [SerializeField] private Slider _sliderProgress;
        [SerializeField] private Image _chest;
        [SerializeField] private Sprite closeChest;
        [SerializeField] private Sprite openChest;
        [SerializeField] private List<int> targetRewardChest;
        [SerializeField] private List<int> targetRewardSkin;
        [SerializeField] private int smashesProgress;
        [SerializeField] private RatingMenu ratingMenu;
        [SerializeField] private AnonserScreen anonserScreen;
        [SerializeField] private RatingScreen ratingScreen;

        private bool _isOpenChest;

        private int _indexProgress;

        private PlayerCharacterSkin _playerSkin;

        #endregion

        private void Start()
        {
            LoadData();
            CheckChest();
            _sliderProgress.maxValue = targetRewardSkin[_indexProgress];
            _sliderProgress.value = smashesProgress;
            _playerSkin = FindObjectOfType<PlayerCharacterSkin>();
            _playerSkin.AddHeadPart(currrencySkin[_indexProgress].characterType);
            _playerSkin.AddArmsPart(currrencySkin[_indexProgress].characterType);
            _playerSkin.AddBodyPart(currrencySkin[_indexProgress].characterType);
            _playerSkin.AddLegsPart(currrencySkin[_indexProgress].characterType);
            currrencySkin[_indexProgress].skin.SetActive(true);
        }

        public void AddProgress()
        {
            smashesProgress++;
            _sliderProgress.value = smashesProgress;
            SaveData();
        }

        public void CheckRewards()
        {
            if (!_isOpenChest)
            {
                if (smashesProgress >= targetRewardChest[_indexProgress])
                {
                    ratingMenu.ChangeChestReward();
                    MoneyWallet.Instance.MoneyPlus(200);
                    _isOpenChest = true;
                }
            }

            if (smashesProgress >= targetRewardSkin[_indexProgress])
            {
                ES3.Save("isRewardPart" + currrencySkin[_indexProgress].name[0], false);
                ES3.Save("isRewardPart" + currrencySkin[_indexProgress].name[1], false);
                ES3.Save("isRewardPart" + currrencySkin[_indexProgress].name[2], false);
                ES3.Save("isRewardPart" + currrencySkin[_indexProgress].name[3], false);
                _indexProgress++;
                _playerSkin.DeactiveAllParts();
                _playerSkin.AddHeadPart(currrencySkin[_indexProgress].characterType);
                _playerSkin.AddArmsPart(currrencySkin[_indexProgress].characterType);
                _playerSkin.AddBodyPart(currrencySkin[_indexProgress].characterType);
                _playerSkin.AddLegsPart(currrencySkin[_indexProgress].characterType);
                smashesProgress = 0;
                _sliderProgress.maxValue = targetRewardSkin[_indexProgress];
                _sliderProgress.value = smashesProgress;
                ratingMenu.ChangeSkinReward();
                _isOpenChest = false;
            }

            CheckChest();
            SaveData();
            ratingScreen.ActiveScreen();
        }

        public void NextSkin()
        {
            anonserScreen.DeactiveScreen();
            currrencySkin[_indexProgress-1].skin.SetActive(false);
            currrencySkin[_indexProgress].skin.SetActive(true);
        }

        private void CheckChest()
        {
            if (_isOpenChest)
            {
                _chest.sprite = openChest;
                return;
            }

            _chest.sprite = closeChest;
        }

        #region Load&SaveData

        private void LoadData()
        {
            smashesProgress = ES3.Load("smashesProgress", smashesProgress);
            _indexProgress = ES3.Load("indexProgress", _indexProgress);
            _isOpenChest = ES3.Load("isOpenChest", _isOpenChest);
        }

        private void SaveData()
        {
            ES3.Save("smashesProgress", smashesProgress);
            ES3.Save("indexProgress", _indexProgress);
            ES3.Save("isOpenChest", _isOpenChest);
        }

        #endregion
    }
}
