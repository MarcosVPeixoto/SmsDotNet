using SmsDotNet.Data;
using SmsDotNet.Entities;
using SmsDotNet.Repositories.Contracts;

namespace SmsDotNet.Repositories.Impl
{
    public class UserRepository : Repository<UserModel>, IUserRepository
    {
        public UserRepository (DataContext dataContext) : base(dataContext)
        {
        }
    }
}
