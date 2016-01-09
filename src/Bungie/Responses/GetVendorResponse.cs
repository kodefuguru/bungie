namespace Bungie.Responses
{
    using Newtonsoft.Json;
    using Models;

    public class GetVendorResponse : DefinitionsResponse
    {
        [JsonProperty("data")]
        public Vendor Vendor { get; set; }
    }
}