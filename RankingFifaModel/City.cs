using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RankingFifaModel
{
    public class City
    {
        public int IdCity {  get; set; }
        public string NameCity { get; set; }
        public int idCountry { get; set; }

        public City()
        {
            IdCity = 0;
            NameCity = string.Empty;
            idCountry = 0;
        }
    }
}
