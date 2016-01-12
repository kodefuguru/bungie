namespace Bungie
{
    using System.Threading.Tasks;

    public interface IUserService
    {
        Task<object> GetAvailableThemes();
        Task<object> GetAccount(long membershipId, MembershipType membershipType);
        Task<object> GetUser(long membershipId);
        Task<object> GetUserAliases(long membershipId);
        Task<object> SearchUsers(string search);
        Task<object> SearchUsers(string search, int page);
    }
}
