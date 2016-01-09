namespace Bungie.Models
{
    using System.Collections.Generic;

    public class Manifest
    {
        public string Version { get; set; }
        public string MobileAssetContentPath { get; set; }
        public MobileGearAssetDataBase[] MobileGearAssetDataBases { get; set; }
        public IDictionary<string, string> MobileWorldContentPaths { get; set;}
        public MobileGearCdn MobileGearCdn { get; set; }
    }

}
