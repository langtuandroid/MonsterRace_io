using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Cor
{
    public class RoadMap : MonoBehaviour
    {
        #region Variables

        [SerializeField] List<Image> lvlProgressImg = new List<Image>();
        [SerializeField] List<Text> textLvls = new List<Text>();
        [SerializeField] Image head;
        [SerializeField] List<Sprite> heads = new List<Sprite>();
        [SerializeField] List<Sprite> progressSprites = new List<Sprite>();
        [SerializeField] List<int> numbersProgress = new List<int>();
        [SerializeField] private int indexProgress;
        [SerializeField] private bool isLobby;
        [SerializeField] SkinsController _skinsController;

        #endregion

        private void Start()
        {
            LoadData();
            if (!isLobby)
            {
                LevelManager.Instance.OnLevelCompleted += UpdateProgrees;
                return;
            }
            CheckProgress();
        }

        public void CheckProgress()
        {
            head.sprite = heads[_skinsController.GetIndexProgress()];
            for(int i = 0; i < lvlProgressImg.Count; i++)
            {
                if (i > indexProgress) lvlProgressImg[i].sprite = progressSprites[0];
                if (i == indexProgress) lvlProgressImg[i].sprite = progressSprites[1];
                if (i < indexProgress) lvlProgressImg[i].sprite = progressSprites[2];
            }
            for(int i = 0; i < textLvls.Count; i++)
            {
                textLvls[i].text = numbersProgress[i].ToString();
            }
        }

        private void UpdateProgrees()
        {
            indexProgress++;
            if(indexProgress >= 4)
            {
                indexProgress = 0;
                for(int i = 0; i< numbersProgress.Count; i++)
                {
                    numbersProgress[i] += 4;
                }
            }
            SaveData();
        }

        #region Load&SaveData

        private void LoadData()
        {
            numbersProgress = ES3.Load("numbersProgress", numbersProgress);
            indexProgress = ES3.Load("indexProgress", indexProgress);
        }

        private void SaveData()
        {
            ES3.Save("numbersProgress", numbersProgress);
            ES3.Save("indexProgress", indexProgress);
        }

        #endregion
    }
}
