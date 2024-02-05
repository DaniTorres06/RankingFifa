namespace RankingFifaModel
{
    public class Players
    {
        public int IdPlayer {get;set;}
        public string? Name { get;set;}
        public string? Position { get;set;}
        

        public Players()
        {
            IdPlayer = 0;
            Name = string.Empty;
            Position = string.Empty;            
        }

    }
}
