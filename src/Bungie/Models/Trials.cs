namespace Bungie.Models
{
    using System;

    public class Trials
    {
        public int HighestWinRank { get; set; }
        public bool Active { get; set; }
        public bool Scheduled { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime ExpirationDate { get; set; }
        public TrialsTicket Ticket { get; set; }
        public TrialsWinDetails[] WinDetails { get; set; }
        public TrialsBuff[] Buffs { get; set; }
        public Currency Currency { get; set; }
    }
}