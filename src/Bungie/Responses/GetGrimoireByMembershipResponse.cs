namespace Bungie.Responses
{
    using Models;
    using Newtonsoft.Json;

    public class GetGrimoireByMembershipResponse
    {
        [JsonProperty("data")]
        public Grimoire Grimoire { get; set; }
        public HashMap<Definitions.Card> CardDefinitions { get; set; }
    }
}