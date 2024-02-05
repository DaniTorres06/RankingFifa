using RankingFifaModel;

namespace RankingFifaBusiness.Interfaces
{
    public interface ITeamBusiness
    {
        bool AddTeam(Team vTeam);
        List<AssociationRegion> ListAssociationRegion();
        List<AssociationZone> ListAssociationZone();
        bool MorePlayers(string vNameTeam);
        List<Team> OneTeamChamionsShips(List<Team> vLstTeam);
        int PlayerAmount(string vNameTeam);
        int PlayerAmountAsociation(int idZone);
        List<Team> TeamChamionsShips(List<Team> vLstTeam);
        List<Team> TeamsConfederation(int idZone);
    }
}