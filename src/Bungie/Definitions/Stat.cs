namespace Bungie.Definitions
{
    public class Stat
    {
        public string StatId { get; set; }
        public int Group { get; set; }
        public int[] PeriodTypes { get; set; }
        public int[] Modes { get; set; }
        public int Category { get; set; }
        public string StatName { get; set; }
        public string StatDescription { get; set; }
        public int UnitType { get; set; }
        public string IconImage { get; set; }
        public string UnitLabel { get; set; }
        public int Weight { get; set; }
    }

}