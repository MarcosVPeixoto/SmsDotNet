using SmsDotNet.Data;
using SmsDotNet.Entities;
using SmsDotNet.Repositories.Contracts;

namespace SmsDotNet.Repositories.Impl
{
    public class ContactRepository : Repository<ContactModel>, IContactRepository
    {
        public ContactRepository(DataContext dataContext) : base(dataContext)
        {
        }

    }
}
