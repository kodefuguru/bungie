namespace Bungie.Models
{
    using System;

    public abstract class Content<TProperties>
    {
        public int ContentId { get; set; }
        public string CType { get; set; }
        public string CmsPath { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime ModifyDate { get; set; }
        public bool AllowComments { get; set; }
        public bool HasAgeGate { get; set; }
        public int MinimumAge { get; set; }
        public string RatingImagePath { get; set; }
        public Author Author { get; set; }
        public bool AutoEnglishPropertyFallback { get; set; }
        public ContentSetProperties Properties { get; set; }
        public ContentRepresentation[] Representations { get; set; }
        public string[] Tags { get; set; }
        public CommentSummary CommentSummary { get; set; }
    }
}