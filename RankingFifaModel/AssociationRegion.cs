namespace RankingFifaModel
{
    public class AssociationRegion
    {
        public int IdRegion { get; set; }
        public string? ZoneRegion { get; set; }

        public AssociationRegion()
        {
            IdRegion = 0;
            ZoneRegion = string.Empty;
        }
    }
}
