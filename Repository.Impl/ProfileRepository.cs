using SmsDotNet.Data;
using SmsDotNet.Entities;
using SmsDotNet.Repositories.Contracts;

namespace SmsDotNet.Repositories.Impl
{
    public class ProfileRepository : Repository<ProfileModel>, IProfileRepository
    {
        public ProfileRepository(DataContext dataContext): base(dataContext)
        {

        }
    }
}
