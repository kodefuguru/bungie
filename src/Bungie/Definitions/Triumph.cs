namespace Bungie.Definitions
{
    public class Triumph
    {
        public string Identifier { get; set; }
        public string Title { get; set; }
        public string Subtitle { get; set; }
        public string IconPath { get; set; }
        public bool HasProgress { get; set; }
        public int MinimumProgress { get; set; }
        public int MaximumProgress { get; set; }
    }
}
