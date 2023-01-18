using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using TMPro;
using DG.Tweening;

namespace PlayKing.Cor
{
    public class BallsMonster : MonoBehaviour
    {
        [System.Serializable]
        public class BallType
        {
            public CharacterColorType ballType;
            public int ammountBallsType;
        }

        [Header("BallMonsterType")]
        [SerializeField] CharacterColorType _characterColorType;
        [SerializeField] CharacterMonsterType _monsterType;

        [Header("MonsterCanvas")]
        [SerializeField] GameObject monsterCanvas;
        [SerializeField] TextMeshProUGUI textCountBalls;

        [Header("ColorsMaterials")]
        [SerializeField] Material[] colorsMaterials;

        [Header("GateMonster")]
        [SerializeField] MeshRenderer[] meshGates;

        [Header("BallMonsterPoses")]
        [SerializeField] Animator _anim;

        [Header("Balls")]
        [SerializeField] List<GameObject> currencyBalls = new List<GameObject>();
        [SerializeField] List<BallType> ballTypes = new List<BallType>();
        [SerializeField] private int needAmmountBalls;
        [SerializeField] private int ammountBalls;
        [SerializeField] private int ammountActivetedBalls;

        [Header("Monsters")]
        [SerializeField] GameObject huggyWuggy;
        [SerializeField] GameObject motherSpider;
        [SerializeField] GameObject baldy;
        [SerializeField] GameObject cartoonCat;
        [SerializeField] GameObject siren;
        [SerializeField] GameObject venom;

        [Header("MonstersBalls")]
        [SerializeField] List<GameObject> huggyWuggyBalls = new List<GameObject>();
        [SerializeField] List<GameObject> motherSpiderBalls = new List<GameObject>();
        [SerializeField] List<GameObject> baldyBalls = new List<GameObject>();
        [SerializeField] List<GameObject> cartoonCatBalls = new List<GameObject>();
        [SerializeField] List<GameObject> sirenBalls = new List<GameObject>();
        [SerializeField] List<GameObject> venomBalls = new List<GameObject>();
        [SerializeField] GameObject monster;
        private bool isDeactivetedMonster;

        CollectableBallsField _collectableBallsField;

        public bool IsFullMonster()
        {
            if (ammountBalls >= needAmmountBalls)
                return true;

            return false;
        }

        public bool IsDeactivetedMonster()
        {
            return isDeactivetedMonster;
        }

        public int GetFillingPercent(CharacterColorType colorType)
        {
            if (needAmmountBalls == 0)
                return 0;

            foreach (var i in ballTypes)
            {
                if (i.ballType == colorType)
                {
                    return (int)(i.ammountBallsType / (needAmmountBalls / 100M));
                }
            }

            return 0;
        }

        public CharacterMonsterType Type()
        {
            return _monsterType;
        }

        private Material SwithcColorBall(CharacterColorType _ballType)
        {
            switch (_ballType)
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
            _collectableBallsField = GameObject.FindObjectOfType<CollectableBallsField>();
            _monsterType = monsterType;

            switch (_monsterType)
            {
                case CharacterMonsterType.HuggyWuggy:
                    huggyWuggy.SetActive(true);
                    currencyBalls = huggyWuggyBalls;
                    _anim.SetTrigger("Pose1");
                    break;
                case CharacterMonsterType.MotherSpider:
                    motherSpider.SetActive(true);
                    currencyBalls = motherSpiderBalls;
                    _anim.SetTrigger("Pose2");
                    break;
                case CharacterMonsterType.Baldy:
                    baldy.SetActive(true);
                    currencyBalls = baldyBalls;
                    _anim.SetTrigger("Pose3");
                    break;
                case CharacterMonsterType.CartoonCat:
                    cartoonCat.SetActive(true);
                    currencyBalls = cartoonCatBalls;
                    _anim.SetTrigger("Pose4");
                    break;
                case CharacterMonsterType.Siren:
                    siren.SetActive(true);
                    currencyBalls = sirenBalls;
                    _anim.SetTrigger("Pose5");
                    break;
                case CharacterMonsterType.Venom:
                    venom.SetActive(true);
                    currencyBalls = venomBalls;
                    _anim.SetTrigger("Pose6");
                    break;
            }

            needAmmountBalls = currencyBalls.Count / 2;
            textCountBalls.text = ammountBalls + "/" + needAmmountBalls;
        }

        public void DeactiveMonster()
        {
            _collectableBallsField.RemoveSpawnedBall(_characterColorType);
            isDeactivetedMonster = true;
            monster.SetActive(false);
        }

        public void BallActiveted(CharacterColorType _ballType)
        {
            if (ammountBalls >= needAmmountBalls)
            {
                monsterCanvas.transform.DOScale(0, 0.3f);
                return;
            }

            AddAmmountBalls(_ballType, 1);
            SearchMaxBalls();
            ChangeGatesColor();
        }

        private void AddAmmountBalls(CharacterColorType _ballType, int number)
        {
            int _balls = 0;
            foreach (var i in ballTypes)
            {
                if (i.ballType == _ballType)
                {
                    i.ammountBallsType += number;
                    _balls = i.ammountBallsType * 2;
                }
            }

            Debug.Log(_balls);

            foreach (var i in ballTypes)
            {
                if (i.ballType != _ballType)
                {
                    i.ammountBallsType--;
                    if (i.ammountBallsType < 0)
                        i.ammountBallsType = 0;
                }
            }

            for (int i = 0; i < _balls + 1; i++)
            {
                currencyBalls[i].GetComponent<MeshRenderer>().material = SwithcColorBall(_ballType);
            }
        }

        private void SearchMaxBalls()
        {
            int k = ballTypes.Max(i => i.ammountBallsType);

            foreach (var i in ballTypes)
            {
                if (i.ammountBallsType == k)
                {
                    _characterColorType = i.ballType;
                    if (ammountBalls < i.ammountBallsType)
                    {
                        ammountBalls = i.ammountBallsType;
                        ammountActivetedBalls += 2;
                        currencyBalls[ammountActivetedBalls - 1].SetActive(true);
                        currencyBalls[ammountActivetedBalls].SetActive(true);
                    }
                }
            }
            
            textCountBalls.text = ammountBalls + "/" + needAmmountBalls;
        }

        private void ChangeGatesColor()
        {
            foreach (var i in meshGates)
            {
                i.material = SwithcColorBall(_characterColorType);
            }
        }
    }
}
