namespace Bungie.Models
{
    public class UserInfo
    {
        public string IconPath { get; set; }
        public MembershipType MembershipType { get; set; }
        public long MembershipId { get; set; }
        public string DisplayName { get; set; }
    }
}