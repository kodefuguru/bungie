namespace Bungie.Models
{
    using System;

    public class Event
    {
        public long EventHash { get; set; }
        public string EventIdentifier { get; set; }
        public DateTime ExpirationDate { get; set; }
        public DateTime StartDate { get; set; }
        public bool ExpirationKnown { get; set; }
    }
}