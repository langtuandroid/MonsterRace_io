using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using TMPro;
using DG.Tweening;
using UnityEngine.Serialization;

namespace Core
{
    public class CollectableMonster : MonoBehaviour
    {
        [System.Serializable]
        public class BallType
        {
            public CharacterColorType ballType;
            public int ammountBallsType;
        }

        #region Variables

        [Header("BallMonsterType")]
        [SerializeField] private CharacterColorType _characterColorType;
        [SerializeField] private CharacterMonsterType _monsterType;

        [Header("MonsterCanvas")]
        [SerializeField] private GameObject monsterCanvas;
        [SerializeField] private TextMeshProUGUI textCountBalls;

        [Header("ColorsMaterials")]
        [SerializeField] private Material[] colorsMaterials;

        [Header("GateMonster")]
        [SerializeField] private MeshRenderer[] meshGates;

        [Header("BallMonsterPoses")]
        [SerializeField] private Transform point;

        [Header("Balls")] 
        [SerializeField] private List<GameObject> currencyBalls;
        [SerializeField] private List<BallType> ballTypes;
        [SerializeField] private int needCountBalls;
        [SerializeField] private int countBalls;
        [SerializeField] private int countActiveBalls;
        
        [Header("BallsMonster")]
        [SerializeField] private BallsMonster ballsMonster;

        [SerializeField] private CollectableBallsField _collectableBallsField;
        [SerializeField] private CollectableMonsterSpawner _monsterSpawner;

        private bool isDeactivetedMonster;

        #endregion

        private void Start()
        {
            _monsterSpawner = FindObjectOfType<CollectableMonsterSpawner>();
        }

        public bool IsFullMonster()
        { 
            return countBalls >= needCountBalls;
        }

        public bool IsDeactivetedMonster()
        {
            return isDeactivetedMonster;
        }

        public int GetFillingPercent(CharacterColorType colorType)
        {
            if (needCountBalls == 0)
                return 0;

            foreach (var i in ballTypes)
            {
                if (i.ballType == colorType)
                {
                    return (int)(i.ammountBallsType / (needCountBalls / 100M));
                }
            }

            return 0;
        }

        public CharacterMonsterType Type()
        {
            return _monsterType;
        }

        private Material SwithcColorBall(CharacterColorType ballType)
        {
            switch (ballType)
            {
                case CharacterColorType.Blue:
                    return colorsMaterials[0];
                case CharacterColorType.Green:
                    return colorsMaterials[1];
                case CharacterColorType.Yellow:
                    return colorsMaterials[2];
                case CharacterColorType.Violet:
                    return colorsMaterials[3];
                case CharacterColorType.Purple:
                    return colorsMaterials[4];
                case CharacterColorType.Red:
                    return colorsMaterials[5];
            }
            return null;
        }

        public void SetMonster(CharacterMonsterType monsterType)
        {
            _monsterType = monsterType;
            _monsterSpawner.NewMonster(monsterType, this, point);
        }

        public void SetBallsMonster(BallsMonster ballsMonster)
        {
            this.ballsMonster = ballsMonster;
            this.ballsMonster.MonsterActive();
            currencyBalls = this.ballsMonster.GetBalls();
            needCountBalls = currencyBalls.Count / 2;
            textCountBalls.text = countBalls + "/" + needCountBalls;
        }

        public void DeactiveMonster()
        {
            if (_collectableBallsField == null)
            {
                _collectableBallsField = GameObject.FindObjectOfType<CollectableBallsField>();
            }
            _collectableBallsField.RemoveSpawnedBall(_characterColorType);
            monsterCanvas.transform.DOScale(0, 0.5f);
            isDeactivetedMonster = true;
        }

        public void BallActiveted(CharacterColorType ballType)
        {
            if (countBalls >= needCountBalls)
            {
                monsterCanvas.transform.DOScale(0, 0.3f);
                return;
            }

            AddAmmountBalls(ballType, 1);
            SearchMaxBalls();
            ChangeGatesColor();
        }

        private void AddAmmountBalls(CharacterColorType ballType, int number)
        {
            var balls = 0;
            foreach (var i in ballTypes)
            {
                if (i.ballType == ballType)
                {
                    i.ammountBallsType += number;
                    balls = i.ammountBallsType * 2;
                }
            }

            foreach (var i in ballTypes)
            {
                if (i.ballType == ballType) 
                    return;
                i.ammountBallsType--;
                if (i.ammountBallsType < 0)
                    i.ammountBallsType = 0;
            }

            for (var i = 0; i < balls + 1; i++)
            {
                if (currencyBalls[i] == null)
                    return;

                currencyBalls[i].GetComponent<MeshRenderer>().material = SwithcColorBall(ballType);
            }
        }

        private void SearchMaxBalls()
        {
            int k = ballTypes.Max(i => i.ammountBallsType);

            foreach (var i in ballTypes)
            {
                if (i.ammountBallsType != k) 
                    return;
                _characterColorType = i.ballType;
                if (countBalls < i.ammountBallsType)
                {
                    countBalls = i.ammountBallsType;
                    countActiveBalls += 2;
                    currencyBalls[countActiveBalls - 1].SetActive(true);
                    currencyBalls[countActiveBalls].SetActive(true);
                }
            }
            
            textCountBalls.text = countBalls + "/" + needCountBalls;
        }

        private void ChangeGatesColor()
        {
            if (meshGates.Length == 0)
                return;

            foreach (var i in meshGates)
            {
                i.material = SwithcColorBall(_characterColorType);
            }
        }
    }
}
