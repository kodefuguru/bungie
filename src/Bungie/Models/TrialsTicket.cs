namespace Bungie.Models
{
    public class TrialsTicket
    {
        public bool HasTicket { get; set; }

        public int MaxWins { get; set; }

        public int MaxLosses { get; set; }

        public int Wins { get; set; }

        public int Losses { get; set; }
    }
}