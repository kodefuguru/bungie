namespace Bungie.Models
{
    using System;

    public class CharacterBase
    {
        public string MembershipId { get; set; }
        public int MembershipType { get; set; }
        public string CharacterId { get; set; }
        public DateTime DateLastPlayed { get; set; }
        public string MinutesPlayedThisSession { get; set; }
        public string MinutesPlayedTotal { get; set; }
        public int PowerLevel { get; set; }
        public long RaceHash { get; set; }
        public long GenderHash { get; set; }
        public long CurrentActivityHash { get; set; }
        public long LastCompletedStoryHash { get; set; }
        public CharacterStats Stats { get; set; }
        public CharacterCustomization Customization { get; set; }
        public int GrimoireScore { get; set; }
        public PeerView PeerView { get; set; }
        public int GenderType { get; set; }
        public int ClassType { get; set; }
        public long BuildStatGroupHash { get; set; }
    }
}