namespace Bungie.Definitions
{
    public class Page
    {
        public string PageId { get; set; }
        public string PageName { get; set; }
        public ImagePack NormalResolution { get; set; }
        public ImagePack HighResolution { get; set; }
        public Card[] CardCollection { get; set; }
    }
}