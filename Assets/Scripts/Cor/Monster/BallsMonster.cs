using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using TMPro;
using DG.Tweening;

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

    [Header("MonsterCanvas")]
    [SerializeField] GameObject monsterCanvas;
    [SerializeField] TextMeshProUGUI textCountBalls;

    [Header("ColorsMaterials")]
    [SerializeField] Material[] colorsMaterials;

    [Header("GateMonster")]
    [SerializeField] MeshRenderer[] meshGates;

    [Header("Balls")]
    [SerializeField] List<GameObject> currencyBalls = new List<GameObject>();
    [SerializeField] private int needAmmountBalls;
    [SerializeField] private int ammountBalls;
    [SerializeField] List<BallType> ballTypes = new List<BallType>();

    public bool IsFullMonster()
    {
        if (ammountBalls >= needAmmountBalls)
            return true;

        return false;
    }

    public int GetFillingPercent()
    {
        if (needAmmountBalls == 0)
            return 0;

        return (int)(ammountBalls / (needAmmountBalls / 100M));
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

    private void Start()
    {
        needAmmountBalls = currencyBalls.Count;
        textCountBalls.text = ammountBalls + "/" + needAmmountBalls;
    }

    public void BallActiveted(CharacterColorType _ballType)
    {
        ammountBalls++;

        if (ammountBalls >= needAmmountBalls)
        {
            //monsterCanvas.transform.DOScale(0, 0.3f);
            return;
        }

        AddAmmountBalls(_ballType, 1);

        textCountBalls.text = ammountBalls + "/" + needAmmountBalls;
        currencyBalls[ammountBalls - 1].SetActive(true);
        currencyBalls[ammountBalls - 1].GetComponent<MeshRenderer>().material = SwithcColorBall(_ballType);

        ChangeGatesColor();
    }

    private void AddAmmountBalls(CharacterColorType _ballType, int number)
    {
        foreach(var i in ballTypes)
        {
            if(i.ballType == _ballType)
            {
                i.ammountBallsType += number;
            }
        }
    }

    private void ChangeGatesColor()
    {
        int k = ballTypes.Max(i => i.ammountBallsType);

        foreach (var i in ballTypes)
        {
            if(i.ammountBallsType == k)
            {
                _characterColorType = i.ballType;
            }
        }

        foreach(var i in meshGates)
        {
            i.material = SwithcColorBall(_characterColorType);
        }
    }
}
