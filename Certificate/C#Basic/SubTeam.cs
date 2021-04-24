namespace HackerRank.Certificate.CBasic
{
    public class SubTeam : Team
    {
        public SubTeam(string name, int no) : base(name, no)
        {
            
        }
        public void ChangeTeamName(string name)
        {
            teamName = name;
        }
        
    }
}