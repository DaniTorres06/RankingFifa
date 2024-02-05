using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RankingFifaModel
{
    public class AssociationZone
    {
        public int IdZone {  get; set; }
        public string? ZoneName { get; set; }
        public List<int> IdRegion { get; set; }

        public AssociationZone()
        {
            IdZone = 0;
            ZoneName = string.Empty;
            IdRegion = new List<int>();
        }
    }
}
