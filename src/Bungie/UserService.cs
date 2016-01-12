namespace Bungie
{
    using System.Threading.Tasks;
    using BaseJump;

    [Route("https://www.bungie.net/platform/user")]
    public class UserService : BungieService
    {
        public UserService(string apiKey) : base(apiKey)
        {
        }

        [Route("GetAvailableThemes")]
        public Task<object> GetAvailableThemes()
        {
            return Request<object>();
        }

        [Route("GetBungieAccount/{membershipId}/{membershipType}")]
        public Task<object> GetAccount(long membershipId, MembershipType membershipType) 
        {
            var model = new
            {
                membershipId,
                membershipType
            };
            
            return Request<object>(model); 
        }

        [Route("GetBungieNetUserById/{membershipId}")]
        public Task<object> GetUser(long membershipId) 
        {
            var model = new
            {
                membershipId
            };

            return Request<object>(model); 
        }

        [Route("GetUserAliases/{membershipId}")]
        public Task<object> GetUserAliases(long membershipId) 
        {
            var model = new
            {
                membershipId
            };

            return Request<object>(model); 
        }


        [Route("SearchUsers")]
        public Task<object> SearchUsers(string search) 
        {
            var model = new
            {
                search
            };

            return Request<object>(model); 
        }

        [Route("SearchUsersPaged/{search}/page")]
        public Task<object> SearchUsers(string search, int page)
        {
            var model = new
            {
                search,
                page
            };

            return Request<object>(model);
        }
    }
}
