namespace Bungie
{
    using System.Threading.Tasks;

    public interface IForumService
    {
        Task<object> GetTagSuggestions(string partialtag);
        Task<object> Poll(int topicId);
        Task<object> GetPostAndParent(int childPostId, bool? showBanned = null);
        Task<object> GetPostAndParentAwaitingApproval(int childPostId, bool? showBanned = null);
        Task<object> GetPostsThreadedPaged(int parentPostId, int page, int pageSize, int replySize, Unknown rootThreadMode = default(Unknown), Unknown sortMode = default(Unknown), bool? showBanned = null);
        Task<object> GetPostsThreadedPagedFromChild(int childPostId, int page, int pageSize, int replySize, Unknown rootThreadMode = default(Unknown), Unknown sortMode = default(Unknown), bool? showBanned = null);
        Task<object> GetTopicForContent(int contentId);
        Task<object> GetTopics(int page, int group, SortDirection sort, Unknown categoryFilter = default(Unknown), string tagstring = null);
        Task<object> GetTopicsPaged(int page, int pageSize, int group, SortDirection sort, Unknown quickDate = default(Unknown), Unknown categoryFilter = default(Unknown), string tagstring = null);
        Task<object> GetTopicsPagedForAlliance(int page, int pageSize, int group, SortDirection sort, Unknown quickDate = default(Unknown), Unknown categoryFilter = default(Unknown), string tagstring = null);
    }
}
