using SmsDotNet.Data;
using SmsDotNet.Repositories.Contracts;
using SmsDotNet.Entities;

namespace SmsDotNet.Repositories.Impl
{
    public class HistoryRepository : Repository<HistoryPasswordModel>, IHistoryPasswordRepository
    {
        public HistoryRepository (DataContext dataContext) : base(dataContext)
        {
        }
    }
}
