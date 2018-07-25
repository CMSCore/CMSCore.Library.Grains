namespace CMSCore.Library.Grains
{
    using System.Threading.Tasks;
    using GrainInterfaces;
    using Messages;
    using Orleans;
    using Repository;

    public class ManageContentGrain : Grain, IManageContentGrain {
        private readonly ICreateContentRepository _createRepository;
        private readonly IDeleteContentRepository _deleteRepository;
        private readonly IUpdateContentRepository _updateRepository;

        public ManageContentGrain(ICreateContentRepository createRepository, IDeleteContentRepository deleteRepository, IUpdateContentRepository updateRepository)
        {
            _createRepository = createRepository;
            _deleteRepository = deleteRepository;
            _updateRepository = updateRepository;
        }


        public async Task<string> CreateComment(CreateCommentViewModel model)
        {
            return await _createRepository.CreateComment(model);
        }

        public async Task<string> CreateFeed(CreateFeedViewModel model)
        {
            return await _createRepository.CreateFeed(model);
        }

        public async Task<string> CreateFeedItem(CreateFeedItemViewModel model)
        {
            return await _createRepository.CreateFeedItem(model);
        }

        public async Task<string> CreatePage(CreatePageViewModel model)
        {
            return await _createRepository.CreatePage(model);
        }

        public async Task<string> CreateUser(CreateUserViewModel model)
        {
            return await _createRepository.CreateUser(model);
        }

        // --------

        public async Task<int> DeleteComment(string id)
        {
            return await _deleteRepository.DeleteComment(id);
        }

        public async Task<int> DeleteContent(string id)
        {

            return await _deleteRepository.DeleteContent(id);
        }

        public async Task<int> DeleteContentVersion(string id)
        {

            return await _deleteRepository.DeleteContentVersion(id);
        }

        public async Task<int> DeleteFeed(string id)
        {

            return await _deleteRepository.DeleteFeed(id);
        }

        public async Task<int> DeleteFeedItem(string id)
        {

            return await _deleteRepository.DeleteFeedItem(id);
        }

        public async Task<int> DeletePage(string id)
        {

            return await _deleteRepository.DeletePage(id);
        }

        public async Task<int> DeleteTag(string id)
        {

            return await _deleteRepository.DeleteTag(id);
        }

        // --------------------

        public async Task<string> UpdateContent(UpdateContentViewModel model)
        {
            return await _updateRepository.UpdateContent(model);
        }

        public async Task<string> UpdateFeedItem(UpdateFeedItemViewModel model)
        {
            return await _updateRepository.UpdateFeedItem(model);
        }

        public async Task<string> UpdatePage(UpdatePageViewModel model)
        {
            return await _updateRepository.UpdatePage(model);
        }
    }
}