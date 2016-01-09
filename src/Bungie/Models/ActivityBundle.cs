namespace Bungie.Models
{
    using System;

    public class ActivityBundle
    {
        public long ActivityBundleHash { get; set; }
        public DateTime ExpirationDate { get; set; }
        public string IconPath { get; set; }
    }
}