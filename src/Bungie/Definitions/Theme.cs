namespace Bungie.Definitions
{
    public class Theme
    {
        public string ThemeId { get; set; }
        public string ThemeName { get; set; }
        public ImagePack NormalResolution { get; set; }
        public ImagePack HighResolution { get; set; }
        public Page[] PageCollection { get; set; }
    }    
}