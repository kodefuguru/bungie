namespace Bungie.Definitions
{
    using System;

    public class TriumphSet
    {
        public long TriumphSetHash { get; set; }
        public string Identifier { get; set; }
        public int Order { get; set; }
        public string Title { get; set; }
        public string IconPath { get; set; }
        public string IncompleteSubtitle { get; set; }
        public string IncompleteDetails { get; set; }
        public string CompletedSubtitle { get; set; }
        public string CompletedDetails { get; set; }
        public string LockedSubtitle { get; set; }
        public string LockedDetails { get; set; }
        public DateTime LockdownDate { get; set; }
        public Triumph[] Triumphs { get; set; }
        public long LockdownUnlockHash { get; set; }
    }
}
