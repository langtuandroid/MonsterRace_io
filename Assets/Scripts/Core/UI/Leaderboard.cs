using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using TMPro;

namespace Core
{
    public class Leaderboard : MonoBehaviour
    {
        private class LeaderboardMember
        {
            public Character Character;
            public CharacterColorType CharacterColorType;
            public MemberBlock MemberBlock;
            public Color ColorMember;
            public TextMeshProUGUI TextMember;
            public string NameMember;
            public int ScoreMember;
            public int BestScoreMember;
        }

        #region Variables

        [SerializeField] private GameObject prefabBlockMember;
        [SerializeField] private Transform[] pointSpawn;

        private List<LeaderboardMember> _leaderboardMembers = new List<LeaderboardMember>();

        #endregion

        #region LeaderboardMemberBlocks

        public void AddMember(Character character, CharacterColorType type, Color color, string nameMember)
        {
            LeaderboardMember leaderboardMember = new LeaderboardMember();
            leaderboardMember.Character = character;
            leaderboardMember.CharacterColorType = type;
            leaderboardMember.ColorMember = color;
            leaderboardMember.NameMember = nameMember;
            leaderboardMember.ScoreMember = 0;
            leaderboardMember.BestScoreMember = 0;
            _leaderboardMembers.Add(leaderboardMember);
            SpawnMemberBlock(leaderboardMember);
        }

        public void RemoveMember(CharacterColorType characterColorType)
        {
            for(int i = 0; i < _leaderboardMembers.Count; i++)
            {
                if(_leaderboardMembers[i].CharacterColorType == characterColorType)
                {
                    Destroy(_leaderboardMembers[i].MemberBlock.gameObject);
                    _leaderboardMembers.RemoveAt(_leaderboardMembers.IndexOf(_leaderboardMembers[i]));
                }
            }

            SortLeaderboardMemebers();
        }

        private void SpawnMemberBlock(LeaderboardMember leaderboard)
        {
            GameObject newBlock = Instantiate(prefabBlockMember, pointSpawn[_leaderboardMembers.Count - 1].position,
                pointSpawn[_leaderboardMembers.Count - 1].rotation);
            newBlock.transform.SetParent(pointSpawn[_leaderboardMembers.Count - 1]);
            MemberBlock memberBlock = newBlock.GetComponent<MemberBlock>();
            memberBlock.SetColorBlock(leaderboard.ColorMember);
            memberBlock.SetProgressBlock(leaderboard.NameMember + " - " + leaderboard.BestScoreMember + "%", leaderboard.BestScoreMember);
            leaderboard.MemberBlock = memberBlock;
        }

        #endregion

        #region ScoreLeaderboard

        public void AddScoreMember(CharacterColorType characterColorType, int score)
        {
            foreach(var i in _leaderboardMembers) 
            {
                if(i.CharacterColorType == characterColorType)
                {
                    if (i.ScoreMember == score)
                        return;

                    i.ScoreMember = score;
                    if (i.BestScoreMember < i.ScoreMember)
                        i.BestScoreMember = i.ScoreMember;
                   
                    if(i.ScoreMember >= 100)
                    { 
                        i.MemberBlock.SetProgressBlock("MONSTER", 100);
                        return;
                    }

                    i.MemberBlock.SetProgressBlock(i.NameMember + " - " + i.BestScoreMember + "%", i.BestScoreMember);
                    i.MemberBlock.BlockAnimation();
                    SortLeaderboardMemebers();
                }
            }
        }

        private void SortLeaderboardMemebers()
        {
            _leaderboardMembers = _leaderboardMembers.OrderBy(i => i.BestScoreMember).ToList();
            int k = 1;

            for (int i = 0; i < _leaderboardMembers.Count; i++) 
            {
                _leaderboardMembers[i].MemberBlock.transform.SetParent(pointSpawn[_leaderboardMembers.Count - k]);
                _leaderboardMembers[i].MemberBlock.transform.position = pointSpawn[_leaderboardMembers.Count - k].position;
                k++;
            }

            foreach(var i in _leaderboardMembers)
            {
                if(i == _leaderboardMembers[_leaderboardMembers.Count - 1])
                {
                    i.Character.CrownActive(true);
                    i.MemberBlock.LeaderBlock(true);
                }
                else
                {
                    i.Character.CrownActive(false);
                    i.MemberBlock.LeaderBlock(false);
                }
            }
        }

        #endregion
    }
}