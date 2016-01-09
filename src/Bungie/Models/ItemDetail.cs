namespace Bungie.Models
{
    public class ItemDetail
    {
        public Item Item { get; set; }
        public TalentNode[] TalentNodes { get; set; }

        /// <summary>
        /// The key is the TalentNode hash.
        /// </summary>
        public HashMap<TalentNodeStats> StatsOnNodes { get; set; }
        public ItemDetailStat[] CharacterStatsToDisplay { get; set; }
        public long[] MaterialItemHashes { get; set; }
        public Unknown MaterialQuantities { get; set; }
    }
}
