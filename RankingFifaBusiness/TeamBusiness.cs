using RankingFifaBusiness.Interfaces;
using RankingFifaModel;

namespace RankingFifaBusiness
{
    public class TeamBusiness : ITeamBusiness
    {
        // Equipos acordes a las distintas zonas
        public List<AssociationZone> ListAssociationZone()
        {
            List<AssociationZone> vLstZone = new();
            /*
             * 
             * 
             * 
             * */
            return vLstZone;
        }

        // Equipos acordes a las distintas zonas
        public List<AssociationRegion> ListAssociationRegion()
        {
            List<AssociationRegion> vLstZone = new();
            /*
             * 
             * */

            return vLstZone;
        }

        // Incorporacion de equipos
        public bool AddTeam(Team vTeam)
        {
            if (vTeam.IdTeam != 0)
            {
                /*
                 * 
                 * 
                 * */
                return true;
            }
            else
            {
                return false;
            }

        }

        // *** Consultas de informacion por equipo ***

        // Obtener la cantidad de jugadores de un equipo.
        public int PlayerAmount(string vNameTeam)
        {
            List<Team> vLstTeam = new();
            int vPlayers = 0;

            var LstCountPlayers = vLstTeam.Where(x => x.NameTeam == vNameTeam).ToList();
            vPlayers = LstCountPlayers[0].Players.Count;

            return vPlayers;
        }

        // Equipos que usaron más de 17 jugadores, 
        public bool MorePlayers(string vNameTeam)
        {
            int quantityPlayer = PlayerAmount(vNameTeam);
            if (quantityPlayer > 17)
            {
                return true;
            }
            {
                return false;
            }
        }

        // Equipos que tengan al menos un título internacional
        public List<Team> OneTeamChamionsShips(List<Team> vLstTeam)
        {
            var ListChampionship = vLstTeam.Where(x => x.ChampionShips.Where(y => y.IsNational == false && x.IdTeam == y.IdTeam).Count() >= 1).ToList();

            return ListChampionship;
        }

        // Equipo que tengan al menos 10 títulos internaciones
        public List<Team> TeamChamionsShips(List<Team> vLstTeam)
        {
            var ListChampionship = vLstTeam.Where(x => x.ChampionShips.Where(y => y.IsNational == false && x.IdTeam == y.IdTeam).Count() >= 10).ToList();

            return ListChampionship;
        }

        // Cantidad de jugadores de una asociacion
        public int PlayerAmountAsociation(int idZone)
        {
            List<Team> vLstTeam = new();
            int vPlayers = 0;

            var LstCountPlayers = vLstTeam.Where(x => x.IdZone == idZone).ToList();
            vPlayers = LstCountPlayers[0].Players.Count;

            return vPlayers;
        }

        // Obtener todos los equipos de una confederacon
        public List<Team> TeamsConfederation(int idZone)
        {
            List<Team> vLstTeam = new();
            int vPlayers = 0;

            var LstCountPlayers = vLstTeam.Where(x => x.IdZone == idZone).ToList();

            return LstCountPlayers;
        }
    }
}
