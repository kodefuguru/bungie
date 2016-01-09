namespace Bungie.Responses
{
    using Models;

    public class GetStatsForAccountResponse
    {
        public StatsMergedCharacter MergedDeletedCharacters { get; set; }
        public StatsMergedCharacter MergedAllCharacters { get; set; }
        public StatsCharacter[] Characters { get; set; }
    }
}