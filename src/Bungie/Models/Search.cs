namespace Bungie.Models
{
    public class Search
    {
        public int TotalResults { get; set; }
        public bool HasMore { get; set; }
        public SearchQuery Query { get; set; }
        public bool UseTotalResults { get; set; }
    }
}