namespace Bungie.Definitions
{
    public class Activity
    {
        public long ActivityHash { get; set; }
        public string ActivityName { get; set; }
        public string ActivityDescription { get; set; }
        public string Icon { get; set; }
        public string ReleaseIcon { get; set; }
        public int ReleaseTime { get; set; }
        public int ActivityLevel { get; set; }
        public long CompletionFlagHash { get; set; }
        public float ActivityPower { get; set; }
        public int MinParty { get; set; }
        public int MaxParty { get; set; }
        public int MaxPlayers { get; set; }
        public long DestinationHash { get; set; }
        public long PlaceHash { get; set; }
        public long ActivityTypeHash { get; set; }
        public int Tier { get; set; }
        public string PgcrImage { get; set; }
        public Reward[] Rewards { get; set; }
        public Unknown[] Skulls { get; set; }
        public bool IsPlaylist { get; set; }
    }
}
