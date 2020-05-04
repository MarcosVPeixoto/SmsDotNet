using System.Data;
using System.Threading.Tasks;

namespace SmsDotNet.Repositories.Contracts
{
    public interface IUnitOfWork
    {
        public IContactRepository contactRepository { get; }
        public IHistoryPasswordRepository historyPasswordRepository { get; }
        public IMessageRepository messageRepository { get; }
        public IProfileRepository profileRepository { get; }
        public IStoryRepository storyRepository { get; }
        public IUserRepository userRepository { get; }

        void ForceBeginTransaction();
        Task CommitAsync();
        void Commit();
        int SaveChanges();
        Task<int> SaveChangesAsync();
        void SetIsolationLevel(IsolationLevel isolationLevel);
        void Dispose();
        void RollbackTransaction();
    }
}
