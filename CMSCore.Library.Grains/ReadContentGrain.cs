namespace CMSCore.Library.Grains
{
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using GrainInterfaces;
    using Messages;
    using Messages.Read;
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
            var result = await _repository.GetFeedItem(this.GetPrimaryKeyString());
            return result;
        }

        public async Task<FeedItemViewModel> GetFeedItemByNormalizedName()
        {
            var result = await _repository.GetFeedItemByNormalizedName(this.GetPrimaryKeyString());
            return result;
        }

        public async Task<PageViewModel> GetPageById()
        {
            var result = await _repository.GetPageById(this.GetPrimaryKeyString());
            return result;
        }

        public async Task<PageViewModel> GetPageByNormalizedName()
        {
            var result = await _repository.GetPageByNormalizedName(this.GetPrimaryKeyString());
            return result;
        }

        public async Task<List<PageTreeViewModel>> GetPageTree()
        {
            var result = await _repository.GetPageTree();
            return result;
        }

        public async Task<List<TagViewModel>> GetTags()
        {
            var result = await _repository.GetTags();
            return result;
        }

        public async Task<List<UserViewModel>> GetUsers()
        {
            var result = await _repository.GetUsers();
            return result;
        }
    }
}