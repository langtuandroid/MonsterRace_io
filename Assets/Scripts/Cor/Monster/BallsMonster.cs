using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallsMonster : MonoBehaviour
{
    [Header("NeedCharacter")]
    [SerializeField] CharacterColorType _characterColorType;

    public bool IsTrueCharacter(CharacterColorType characterColorType)
    {
        if (_characterColorType == characterColorType)
            return true;

        return false;
    }
}
