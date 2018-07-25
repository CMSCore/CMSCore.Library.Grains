namespace CMSCore.Library.Grains
{
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using GrainInterfaces;
    using Messages;
    using Orleans;
    using Orleans.Concurrency;
    using Repository;

    public class ReadContentGrain : Grain, IReadContentGrain
    {
        private readonly IReadContentRepository _repository;

        public ReadContentGrain(IReadContentRepository repository)
        {
            _repository = repository;
        }

        public async Task<FeedItemViewModel> GetFeedItem()
        {
            return await _repository.GetFeedItem(this.GetPrimaryKeyString());
        }

        public async Task<FeedItemViewModel> GetFeedItemByNormalizedName()
        {
            return await _repository.GetFeedItemByNormalizedName(this.GetPrimaryKeyString());
        }

        public async Task<PageViewModel> GetPageById()
        {
            return await _repository.GetPageById(this.GetPrimaryKeyString());
        }

        public async Task<PageViewModel> GetPageByNormalizedName()
        {
            return await _repository.GetPageByNormalizedName(this.GetPrimaryKeyString());
        }

        public async Task<IEnumerable<PageTreeViewModel>> GetPageTree()
        {
            return await _repository.GetPageTree();
        }

        public async Task<IEnumerable<TagViewModel>> GetTags()
        { 
            return await _repository.GetTags();
        }

        public async Task<IEnumerable<UserViewModel>> GetUsers()
        {
            return await _repository.GetUsers();
        }
    }
}