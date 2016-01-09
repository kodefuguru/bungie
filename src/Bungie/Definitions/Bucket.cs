namespace Bungie.Definitions
{
    public class Bucket
    {
        public long BucketHash { get; set; }
        public string BucketName { get; set; }
        public string BucketDescription { get; set; }
        public int Scope { get; set; }
        public int Category { get; set; }
        public int BucketOrder { get; set; }
        public string BucketIdentifier { get; set; }
        public int ItemCount { get; set; }
        public int Location { get; set; }
        public bool HasTransferDestination { get; set; }
        public bool Enabled { get; set; }
    }
}
