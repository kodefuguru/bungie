namespace Bungie.Models
{
    using System;

    public class Author
    {
        public int MembershipId { get; set; }
        public string UniqueName { get; set; }
        public string DisplayName { get; set; }
        public int ProfilePicture { get; set; }
        public int ProfileTheme { get; set; }
        public int UserTitle { get; set; }
        public string SuccessMessageFlags { get; set; }
        public bool IsDeleted { get; set; }
        public string About { get; set; }
        public DateTime FirstAccess { get; set; }
        public DateTime LastUpdate { get; set; }
        public string PsnDisplayName { get; set; }
        public string XboxDisplayName { get; set; }
        public bool ShowActivity { get; set; }
        public int FollowerCount { get; set; }
        public int FollowingUserCount { get; set; }
        public string Locale { get; set; }
        public bool LocaleInheritDefault { get; set; }
        public bool ShowGroupMessaging { get; set; }
        public string ProfilePicturePath { get; set; }
        public string ProfileThemeName { get; set; }
        public string UserTitleDisplay { get; set; }
        public string StatusText { get; set; }
        public DateTime StatusDate { get; set; }
    }
}