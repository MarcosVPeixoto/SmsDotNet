using Microsoft.Extensions.Logging;
using SmsDotNet.Data;
using SmsDotNet.Repositories.Contracts;
using System.Data;
using System.Threading.Tasks;

namespace SmsDotNet.Repositories.Impl
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DataContext _dataContext;
        private readonly ILogger _logger;

        private IContactRepository _contactRepository;
        private IHistoryPasswordRepository _historyRepository;
        private IMessageRepository _messageRepository;
        private IProfileRepository _profileRepository;
        private IStoryRepository _storyRepository;
        private IUserRepository _userRepository;

        public IContactRepository contactRepository => 
            _contactRepository ?? (_contactRepository = new ContactRepository (_dataContext));

        public IHistoryPasswordRepository historyPasswordRepository =>
            _historyRepository ?? (_historyRepository = new HistoryRepository (_dataContext));

        public IMessageRepository messageRepository =>
            _messageRepository ?? (_messageRepository = new MessageRepository (_dataContext));

        public IProfileRepository profileRepository => 
            _profileRepository ?? (_profileRepository = new ProfileRepository (_dataContext));

        public IStoryRepository storyRepository => 
            _storyRepository ?? (_storyRepository = new StoryRepository(_dataContext));

        public IUserRepository userRepository => 
            _userRepository ?? (_userRepository = new UserRepository(_dataContext));

        public void Commit()
        {
            throw new System.NotImplementedException();
        }

        public Task CommitAsync()
        {
            throw new System.NotImplementedException();
        }

        public void Dispose()
        {
            throw new System.NotImplementedException();
        }

        public void ForceBeginTransaction()
        {
            throw new System.NotImplementedException();
        }

        public void RollbackTransaction()
        {
            throw new System.NotImplementedException();
        }

        public int SaveChanges()
        {
            throw new System.NotImplementedException();
        }

        public Task<int> SaveChangesAsync()
        {
            throw new System.NotImplementedException();
        }

        public void SetIsolationLevel(IsolationLevel isolationLevel)
        {
            throw new System.NotImplementedException();
        }
    }
}
