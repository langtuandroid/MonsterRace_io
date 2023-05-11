using System.Collections.Generic;
using UnityEngine;

namespace Cor
{
    public class CharacterSettings : MonoBehaviour
    {
        #region Variables

        [SerializeField] CharacterColorType characterColorType;
        [SerializeField] List<CharacterMonsterType> monsterTypes = new List<CharacterMonsterType>();
        [SerializeField] string nameCharacter;
        [SerializeField] Color colorCharacter;
        [SerializeField] MeshRenderer basket;
        [SerializeField] Color basketColor;
        [SerializeField] CharacterStates _characterState;
        [SerializeField] CharacterSkins _characterSkins;
        [SerializeField] Character _character;
        [SerializeField] NameGenerator nameGenerator;
        [SerializeField] PlayerName playerName;
        [SerializeField] CollectableMonster ballsMonster;

        private Leaderboard _leaderboard;
        private SkinsController _skinsController;

        #endregion

        public CharacterColorType Type()
        {
            return characterColorType;
        }

        private void Start()
        {
            _skinsController = GameObject.FindObjectOfType<SkinsController>();
            _leaderboard = GameObject.FindObjectOfType<Leaderboard>();

            LevelManager.Instance.OnLevelStart += SetCharacterSettings;
            SetMonsterType();
            SetBasketColor();
        }

        public void SetupCollectableMonster(CollectableMonster collectableMonster)
        {
            ballsMonster = collectableMonster;
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
                nameCharacter = nameGenerator.Name();
            
            if(playerName != null)
                nameCharacter = playerName.Name();
      
            _leaderboard.AddMember(_character, characterColorType, colorCharacter, nameCharacter);
            _character.SetCharacterSettings(characterColorType);
        }
    }
}
