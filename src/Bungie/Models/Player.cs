namespace Bungie.Models
{
    public class Player
    {
        public UserInfo DestinyUserInfo { get; set; }
        public string CharacterClass { get; set; }
        public int CharacterLevel { get; set; }
        public int LightLevel { get; set; }
        public UserInfo BungieNetUserInfo { get; set; }
        public string ClanName { get; set; }
    }
}