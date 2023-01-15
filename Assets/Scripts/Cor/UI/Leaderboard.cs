using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using TMPro;

namespace PlayKing.Cor
{
    public class Leaderboard : MonoBehaviour
    {
        public class LeaderboardMember
        {
            public Character character;
            public CharacterColorType characterColorType;
            public MemberBlock memeberBlock;
            public Color colorMember;
            public TextMeshProUGUI textMemeber;
            public string nameMemeber;
            public int scoreMember;
            public int bestScoreMember;
        }

        [SerializeField] GameObject prefabBlockMember;
        [SerializeField] Transform[] pointSpawn;

        List<LeaderboardMember> leaderboradMembers = new List<LeaderboardMember>();

        public void AddMember(Character _character, CharacterColorType type, Color color, string name)
        {
            LeaderboardMember _leaderboardMember = new LeaderboardMember();
            _leaderboardMember.character = _character;
            _leaderboardMember.characterColorType = type;
            _leaderboardMember.colorMember = color;
            _leaderboardMember.nameMemeber = name;
            _leaderboardMember.scoreMember = 0;
            _leaderboardMember.bestScoreMember = 0;
            leaderboradMembers.Add(_leaderboardMember);
            SpawnMemberBlock(_leaderboardMember);
        }

        public void AddScoreMemeber(CharacterColorType _characterColorType, int score)
        {
            foreach(var i in leaderboradMembers) 
            {
                if(i.characterColorType == _characterColorType)
                {
                    if (i.scoreMember == score)
                        return;

                    i.scoreMember = score;
                    if (i.bestScoreMember < i.scoreMember)
                        i.bestScoreMember = i.scoreMember;
                   
                    if(i.scoreMember >= 100)
                    { 
                        i.memeberBlock.SetTextBlock("MONSTER");
                        return;
                    }

                    i.memeberBlock.SetTextBlock(i.nameMemeber + " - " + i.bestScoreMember + "%");
                    i.memeberBlock.BlockAnimation();
                    SortLeaderboardMemebers();
                }
            }
        }

        private void SortLeaderboardMemebers()
        {
            leaderboradMembers = leaderboradMembers.OrderBy(i => i.bestScoreMember).ToList();
            int k = 1;

            for (int i = 0; i < leaderboradMembers.Count; i++) 
            {
                leaderboradMembers[i].memeberBlock.transform.parent = pointSpawn[leaderboradMembers.Count - k];
                leaderboradMembers[i].memeberBlock.transform.position = pointSpawn[leaderboradMembers.Count - k].position;
                k++;
            }

            foreach(var i in leaderboradMembers)
            {
                if(i == leaderboradMembers[leaderboradMembers.Count - 1])
                {
                    i.character.CrownActive(true);
                }
                else
                {
                    i.character.CrownActive(false);
                }
            }
        }

        private void SpawnMemberBlock(LeaderboardMember leaderboard)
        {
            GameObject newBlock = Instantiate(prefabBlockMember, pointSpawn[leaderboradMembers.Count - 1].position,
                pointSpawn[leaderboradMembers.Count - 1].rotation);
            newBlock.transform.parent = pointSpawn[leaderboradMembers.Count - 1];
            MemberBlock _memberBlock = newBlock.GetComponent<MemberBlock>();
            _memberBlock.SetColorBlock(leaderboard.colorMember);
            _memberBlock.SetTextBlock(leaderboard.nameMemeber + " - " + leaderboard.bestScoreMember + "%");
            leaderboard.memeberBlock = _memberBlock;
        }
    }
}
