namespace Bungie.Models
{
    public class Account
    {
        public string MembershipId { get; set; }
        public int MembershipType { get; set; }
        public Character[] Characters { get; set; }
        public string ClanName { get; set; }
        public string ClanTag { get; set; }
        public CharacterInventory Inventory { get; set; }
        public int GrimoireScore { get; set; }
        public VendorReceipt[] VendorReceipts { get; set; }
        public int Versions { get; set; }
    }
}
