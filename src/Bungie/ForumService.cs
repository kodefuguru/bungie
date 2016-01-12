namespace Bungie
{
    using System.Threading.Tasks;
    using BaseJump;

    public class ForumService : BungieService, IForumService
    {
        public ForumService(string apiKey)
            : base(apiKey)
        {
        }

        [Route("GetForumTagSuggestions")]
        public Task<object> GetTagSuggestions(string partialtag)
        {
            var model = new
            {
                partialtag
            };

            return Request<object>(model);
        }

        [Route("Poll/{topicId}")]
        public Task<object> Poll(int topicId)
        {
            var model = new
            {
                topicId
            };

            return Request<object>(model);
        }

        [Route("GetPostAndParent/{childPostId}")]
        public Task<object> GetPostAndParent(int childPostId, bool? showBanned = null)
        {
            var model = new
            {
                childPostId,
                showBanned
            };

            return Request<object>(model);
        }

        [Route("GetPostAndParentAwaitingApproval/{childPostId}")]
        public Task<object> GetPostAndParentAwaitingApproval(int childPostId, bool? showBanned = null)
        {
            var model = new
            {
                childPostId,
                showBanned
            };

            return Request<object>(model);
        }

        [Route("GetPostsThreadedPaged/{parentPostId}/{page}/{pageSize}/{replySize}/{getParentPost}/{rootThreadMode}/{sortMode}")]
        public Task<object> GetPostsThreadedPaged(int parentPostId, int page, int pageSize, int replySize, Unknown rootThreadMode = default(Unknown), Unknown sortMode = default(Unknown), bool? showBanned = null)
        {
            var model = new
            {
                parentPostId, 
                page, 
                pageSize, 
                replySize, 
                rootThreadMode, 
                sortMode, 
                showBanned
            };

            return Request<object>(model);
        }

        [Route("GetPostsThreadedPagedFromChild/{childPostId}/{page}/{pageSize}/{replySize}/{rootThreadMode}/{sortMode}")]
        public Task<object> GetPostsThreadedPagedFromChild(int childPostId, int page, int pageSize, int replySize, Unknown rootThreadMode = default(Unknown), Unknown sortMode = default(Unknown), bool? showBanned = null)
        {
            var model = new
            {
                childPostId,
                page,
                pageSize,
                replySize,
                rootThreadMode,
                sortMode,
                showBanned
            };

            return Request<object>(model);
        }

        [Route("GetTopicForContent/{contentId}")]
        public Task<object> GetTopicForContent(int contentId)
        {
            var model = new
            {
                contentId
            };

            return Request<object>(model);
        }

        [Route("GetTopicsPagedSimple/{page}/{group}/{sort}/{categoryFilter}")]
        public Task<object> GetTopics(int page, int group, SortDirection sort, Unknown categoryFilter = default(Unknown), string tagstring = null)
        {
            var model = new
            {
                page, 
                group, 
                sort, 
                categoryFilter, 
                tagstring
            };

            return Request<object>(model);
        }

        [Route("GetTopicsPaged/{page}/{pageSize}/{group}/{sort}/{quickDate}/{categoryFilter}")]
        public Task<object> GetTopicsPaged(int page, int pageSize, int group, SortDirection sort, Unknown quickDate = default(Unknown), Unknown categoryFilter = default(Unknown), string tagstring = null)
        {
            var model = new
            {
                page,
                pageSize,
                group,
                sort,
                quickDate,
                categoryFilter,
                tagstring
            };

            return Request<object>(model);
        }

        [Route("GetTopicsPagedForAlliance/{page}/{pageSize}/{group}/{sort}/{quickDate}/{categoryFilter}")]
        public Task<object> GetTopicsPagedForAlliance(int page, int pageSize, int group, SortDirection sort, Unknown quickDate = default(Unknown), Unknown categoryFilter = default(Unknown), string tagstring = null)
        {
            var model = new
            {
                page,
                pageSize,
                group,
                sort,
                quickDate,
                categoryFilter,
                tagstring
            };

            return Request<object>(model);
        }
    }
}
