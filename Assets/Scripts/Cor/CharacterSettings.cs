using System.Collections.Generic;
using UnityEngine;

namespace PlayKing.Cor
{
    public class CharacterSettings : MonoBehaviour
    {
        [SerializeField] CharacterColorType characterColorType;
        [SerializeField] List<CharacterMonsterType> monsterTypes = new List<CharacterMonsterType>();
        [SerializeField] string nameCharacter;
        [SerializeField] Color colorCharacter;
        [SerializeField] MeshRenderer basket;
        [SerializeField] Color basketColor;
        [SerializeField] private bool isPlayer;
        [SerializeField] NameGenerator nameGenerator;
        [SerializeField] BallsMonster ballsMonster;
        Leaderboard _leaderboard;
        CharacterSkins _characterSkins;
        Character _character;

        public CharacterColorType Type()
        {
            return characterColorType;
        }

        private void Start()
        {
            _leaderboard = GameObject.FindObjectOfType<Leaderboard>();
            _characterSkins = GetComponent<CharacterSkins>();
            _character = GetComponentInChildren<Character>();

            LevelController.Instance.OnLevelStart.AddListener(SetCharacterSettings);
            SetMonsterType();
            SetBasketColor();
        }

        public void SetMonsterType()
        {
            if (!isPlayer)
            {
                int random = Random.Range(0, monsterTypes.Count);
                _characterSkins.SetType(monsterTypes[random]);
            }

            if (isPlayer)
            {
                if (LevelController.Instance.LvlNumber() < 3)
                {
                    _characterSkins.SetType(CharacterMonsterType.Venom);
                }
            }

            ballsMonster.SetMonster(_characterSkins.Type());
        }

        private void SetBasketColor()
        {
            basket.material.color = basketColor;
        }

        private void SetCharacterSettings()
        {
            if(nameGenerator != null)
            {
                nameCharacter = nameGenerator.Name();
            }
            _leaderboard.AddMember(_character, characterColorType, colorCharacter, nameCharacter);
            _character.SetCharacterSettings(characterColorType);
        }
    }
}
