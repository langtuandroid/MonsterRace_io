using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;

namespace Core
{
    public class RoadMap : MonoBehaviour
    {
        #region Variables

        [SerializeField] private List<Image> lvlProgressImg = new List<Image>();
        [SerializeField] private List<Text> textLvls = new List<Text>();
        [SerializeField] private Image head;
        [SerializeField] private List<Sprite> heads = new List<Sprite>();
        [SerializeField] private List<Sprite> progressSprites = new List<Sprite>();
        [SerializeField] private List<int> numbersProgress = new List<int>();
        [SerializeField] private SkinsController skinsController;
        [SerializeField] private int indexProgress;
        [SerializeField] private int levelsProgress;
        
        #endregion

        private void Start()
        {
            LoadData();
            if(levelsProgress != LevelManager.Instance.GetLvlNumber())
                UpdateProgress();
            CheckProgress();
        }

        private void CheckProgress()
        {
            head.sprite = heads[skinsController.GetIndexProgress()];
            
            for(var i = 0; i < lvlProgressImg.Count; i++)
            {
                if (i > indexProgress) lvlProgressImg[i].sprite = progressSprites[0];
                if (i == indexProgress) lvlProgressImg[i].sprite = progressSprites[1];
                if (i < indexProgress) lvlProgressImg[i].sprite = progressSprites[2];
            }
            
            for(var i = 0; i < textLvls.Count; i++)
            {
                textLvls[i].text = numbersProgress[i].ToString();
            }
        }

        private void UpdateProgress()
        {
            indexProgress++;
            levelsProgress++;
            
            if(indexProgress >= 4)
            {
                indexProgress = 0;
                for(var i = 0; i< numbersProgress.Count; i++)
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
            levelsProgress = ES3.Load("levelsProgress", levelsProgress);
        }

        private void SaveData()
        {
            ES3.Save("numbersProgress", numbersProgress);
            ES3.Save("indexProgress", indexProgress);
            ES3.Save("levelsProgress", levelsProgress);
        }

        #endregion
    }
}
