using SmsDotNet.Data;
using SmsDotNet.Entities;
using SmsDotNet.Repositories.Contracts;

namespace SmsDotNet.Repositories.Impl
{
    public class StoryRepository : Repository<StoryModel>, IStoryRepository
    {
        public StoryRepository(DataContext dataContext) : base(dataContext)
        {
        }
    }
}
