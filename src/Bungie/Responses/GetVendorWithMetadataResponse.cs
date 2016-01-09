namespace Bungie.Responses
{
    using Bungie.Models;

    public class GetVendorWithMetadataResponse : DefinitionsResponse
    {
        public VendorWithMetadata Data { get; set; }
    }
}