using System.Collections.Generic;
using UnityEngine;
using TMPro;
using DG.Tweening;

public class BallsMonster : MonoBehaviour
{
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
    private int ammountBlueBalls;
    private int ammountGreenBalls;
    private int ammountYellowBalls;
    private int ammountVioletBalls;
    private int ammountPurpleBalls;
    private int ammountRedBalls;

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

    private int GetAmmountBalls(CharacterColorType _ballType, int number)
    {
        switch (_ballType)
        {
            case CharacterColorType.Blue:
                return ammountBlueBalls + number;
            case CharacterColorType.Green:
                return ammountGreenBalls + number;
            case CharacterColorType.Yellow:
                return ammountYellowBalls + number;
            case CharacterColorType.Violet:
                return ammountVioletBalls + number;
            case CharacterColorType.Purple:
                return ammountPurpleBalls + number;
            case CharacterColorType.Red:
                return ammountRedBalls + number;
        }

        return 0;
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

        textCountBalls.text = ammountBalls + "/" + needAmmountBalls;
        currencyBalls[ammountBalls - 1].SetActive(true);
        currencyBalls[ammountBalls - 1].GetComponent<MeshRenderer>().material = SwithcColorBall(_ballType);
        GetAmmountBalls(_ballType, 1);
        //ChangeGatesColor();
    }

    private void ChangeGatesColor()
    {
        foreach(var i in meshGates)
        {
            i.material = SwithcColorBall(_characterColorType);
        }
    }
}
