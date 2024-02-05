using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RankingFifaModel
{
    public class Country
    {
        public int IdConuntry { get; set; }
        public string Name { get; set; }
        public int IdAssociatonZona {get;set;}

        public Country()
        {
            IdConuntry = 0;
            Name = string.Empty;
            IdAssociatonZona = 0;
        }

    }
}
