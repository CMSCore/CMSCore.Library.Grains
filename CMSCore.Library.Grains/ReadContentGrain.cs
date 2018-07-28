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

        public async Task<Immutable<FeedItemViewModel>> GetFeedItem()
        {
            var result = await _repository.GetFeedItem(this.GetPrimaryKeyString());
            return new Immutable<FeedItemViewModel>(result);
        }

        public async Task<Immutable<FeedItemViewModel>> GetFeedItemByNormalizedName()
        {
            var result = await _repository.GetFeedItemByNormalizedName(this.GetPrimaryKeyString());
            return new Immutable<FeedItemViewModel>(result);
        }

        public async Task<Immutable<PageViewModel>> GetPageById()
        {
            var result = await _repository.GetPageById(this.GetPrimaryKeyString());
            return new Immutable<PageViewModel>(result);
        }

        public async Task<Immutable<PageViewModel>> GetPageByNormalizedName()
        {
            var result = await _repository.GetPageByNormalizedName(this.GetPrimaryKeyString());
            return new Immutable<PageViewModel>(result);
        }

        public async Task<Immutable<PageTreeViewModel [ ]>> GetPageTree()
        {
            var result = await _repository.GetPageTree();
            return new Immutable<PageTreeViewModel [ ]>(result);
        }

        public async Task<Immutable<TagViewModel [ ]>> GetTags()
        {
            var result = await _repository.GetTags();
            return new Immutable<TagViewModel [ ]>(result);
        }

        public async Task<Immutable<UserViewModel [ ]>> GetUsers()
        {
            var result = await _repository.GetUsers();
            return new Immutable<UserViewModel [ ]>(result);
        }
    }
}