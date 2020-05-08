using SmsDotNet.Entities;

namespace SmsDotNet.Repositories.Contracts
{
    public interface IUserRepository : IRepository<UserModel>
    {
        public bool EmailExists(string email);
        void Update(BaseModel updatedModel);
    }
}
