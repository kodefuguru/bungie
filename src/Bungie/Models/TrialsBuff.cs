namespace Bungie.Models
{
    public class TrialsBuff
    {
        public long ItemHash { get; set; }

        public SaleItem SaleItem { get; set; }

        public bool IsUsed { get; set; }

        public bool IsActive { get; set; }
    }
}