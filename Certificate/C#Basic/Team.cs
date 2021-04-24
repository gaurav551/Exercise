namespace HackerRank.Certificate.CBasic
{
    public class Team
    {
        public string teamName;
        public int noOfPlayer;
        public Team(string name, int no)
        {
           teamName = name;
           noOfPlayer = no;   
        }
        public void AddPlayer(int count)
        {
            noOfPlayer+=count;
        }
        public bool RemovePlayer(int count)
        {
            var decrease = noOfPlayer - count;
            if(decrease<0)
            {
                return false;
            }
            noOfPlayer = decrease;
            return true;

        }
       
        
    }
}