using SmsDotNet.Data;
using SmsDotNet.Entities;
using SmsDotNet.Repositories.Contracts;
using System.Threading.Tasks;

namespace SmsDotNet.Repositories.Impl
{
    public class MessageRepository : Repository<MessageModel>, IMessageRepository
    {
        public MessageRepository (DataContext dataContext) : base (dataContext)
        {

        }

        public Task DeleteAllTalks(int IdOwner)
        {
            throw new System.NotImplementedException();
        }

        public Task DeleteByOwner(int IdOwner, int IdTarget)
        {
            throw new System.NotImplementedException();
        }

        public Task DeleteByTarget(int IdOwner, int IdTarget)
        {
            throw new System.NotImplementedException();
        }

        public Task DeleteTalk(int IdOwner, int IdTarget)
        {
            throw new System.NotImplementedException();
        }

        public Task GetLastMessages(int IdOwner)
        {
            throw new System.NotImplementedException();
        }

        public Task GetTalk(int IdOwner, int IdTarget)
        {
            throw new System.NotImplementedException();
        }
    }
}
