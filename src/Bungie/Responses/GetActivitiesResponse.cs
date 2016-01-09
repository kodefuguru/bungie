namespace Bungie.Responses
{
    using Models;

    public class GetActivitiesResponse : DefinitionsResponse
    {
        public ActivityPage Data { get; set; }
    }
}