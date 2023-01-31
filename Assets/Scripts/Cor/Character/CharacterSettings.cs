using System.Collections.Generic;
using UnityEngine;

namespace BlueStellar.Cor
{
    public class CharacterSettings : MonoBehaviour
    {
        [SerializeField] CharacterColorType characterColorType;
        [SerializeField] List<CharacterMonsterType> monsterTypes = new List<CharacterMonsterType>();
        [SerializeField] string nameCharacter;
        [SerializeField] Color colorCharacter;
        [SerializeField] MeshRenderer basket;
        [SerializeField] Color basketColor;
        [SerializeField] NameGenerator nameGenerator;
        [SerializeField] PlayerName playerName;
        [SerializeField] CollectableMonster ballsMonster;

        Leaderboard _leaderboard;
        public SkinsController _skinsController;
        CharacterStates _characterState;
        CharacterSkins _characterSkins;
        Character _character;

        public CharacterColorType Type()
        {
            return characterColorType;
        }

        private void Start()
        {
            _skinsController = GameObject.FindObjectOfType<SkinsController>();
            _leaderboard = GameObject.FindObjectOfType<Leaderboard>();
            _characterState = GetComponent<CharacterStates>();
            _characterSkins = GetComponent<CharacterSkins>();
            _character = GetComponentInChildren<Character>();

            LevelController.Instance.OnLevelStart.AddListener(SetCharacterSettings);
            SetMonsterType();
            SetBasketColor();
        }

        public void SetMonsterType()
        {
            if (!_characterState.IsPlayerCharacter())
            {
                int random = Random.Range(0, monsterTypes.Count);
                _characterSkins.SetType(monsterTypes[random]);
                ballsMonster.SetMonster(monsterTypes[random]);
                return;
            }

            if (_characterState.IsPlayerCharacter())
            {
                _characterSkins.SetType(monsterTypes[_skinsController.OpenSkinMumber()]);
                ballsMonster.SetMonster(monsterTypes[_skinsController.OpenSkinMumber()]);
            }
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
            if(playerName != null)
            {
                nameCharacter = playerName.Name();
            }
            _leaderboard.AddMember(_character, characterColorType, colorCharacter, nameCharacter);
            _character.SetCharacterSettings(characterColorType);
        }
    }
}
