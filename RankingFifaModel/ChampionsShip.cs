using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RankingFifaModel
{
    public class ChampionsShip
    {
        public int IdChampionsShip { get; set; }
        public string? Name { get; set; }
        public int IdTeam { get; set; }
        public bool IsNational { get; set; }

        public ChampionsShip()
        {
            IdChampionsShip = 0;
            Name = string.Empty;
            IdTeam = 0;
            IsNational = false;

        }

    }
}
