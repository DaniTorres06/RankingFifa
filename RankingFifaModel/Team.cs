using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RankingFifaModel
{
    public class Team
    {
        public int IdTeam { get; set; }
        public string NameTeam { get; set; }
        public List<Players> Players { get; set; }
        public int IdZone { get; set; }
        public int FifaPoints { get; set; }
        public List<ChampionsShip> ChampionShips { get; set; }


        public Team()
        {
            IdTeam = 0;            
            NameTeam = string.Empty;
            Players = new List<Players>();
            IdZone = 0;
            FifaPoints = 0;
            ChampionShips = new();
        }

    }   
    
}
