using Microsoft.EntityFrameworkCore.Internal;
using SmsDotNet.Data;
using SmsDotNet.Entities;
using SmsDotNet.Repositories.Contracts;
using System.Linq;

namespace SmsDotNet.Repositories.Impl
{
    public class UserRepository : Repository<UserModel>, IUserRepository
    {
        public UserRepository (DataContext dataContext) : base(dataContext)
        {
        }
        public bool EmailExists(string email)
        {
            var user = _models.Any(e => e.Email == email);
            return user;
        }
    }
}
