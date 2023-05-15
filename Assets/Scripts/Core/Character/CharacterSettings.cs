using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

namespace Core
{
    public class CharacterSettings : MonoBehaviour
    {
        #region Variables

        [SerializeField] private CharacterColorType characterColorType;
        [SerializeField] private List<CharacterMonsterType> monsterTypes;
        [SerializeField] private string nameCharacter;
        [SerializeField] private Color colorCharacter;
        [SerializeField] private MeshRenderer basket;
        [SerializeField] private Color basketColor;
        [SerializeField] private CharacterStates characterState;
        [SerializeField] private CharacterSkins characterSkins;
        [SerializeField] private Character character;
        [SerializeField] private NameGenerator nameGenerator;
        [SerializeField] private PlayerName playerName;
        [SerializeField] private CollectableMonster ballsMonster;

        private Leaderboard _leaderboard;
        private SkinsController _skinsController;

        #endregion

        private void Start()
        {
            LevelManager.Instance.OnLevelStart += SetCharacterSettings;
            InitCharacterSettings();
        }

        public void SetupSkinController(SkinsController skinsController)
        {
            _skinsController = skinsController;
        }

        public void SetLeaderborad(Leaderboard leaderboard)
        {
            _leaderboard = leaderboard;
        }
        
        public void SetCollectableMonster(CollectableMonster collectableMonster)
        {
            ballsMonster = collectableMonster;
        }

        private void InitCharacterSettings()
        {
            characterState.Init(_skinsController);
            basket.material.color = basketColor;
            
            if (characterState.IsPlayerCharacter())
            { 
                characterSkins.SetType(monsterTypes[_skinsController.OpenSkinMember()]);
                ballsMonster.SetMonster(monsterTypes[_skinsController.OpenSkinMember()]);
                return;
            }
            
            var random = Random.Range(0, monsterTypes.Count);
            characterSkins.SetType(monsterTypes[random]);
            ballsMonster.SetMonster(monsterTypes[random]);
        }
        
        private void SetCharacterSettings()
        {
            if(nameGenerator != null)
                nameCharacter = nameGenerator.Name();
            
            if(playerName != null)
                nameCharacter = playerName.Name();
      
            _leaderboard.AddMember(character, characterColorType, colorCharacter, nameCharacter);
            character.SetCharacterSettings(characterColorType, _leaderboard);
        }
    }
}
