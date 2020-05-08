using SmsDotNet.Entities;
using SmsDotNet.Exceptions;
using SmsDotNet.Repositories.Contracts;
using System.Threading.Tasks;

namespace SmsDotNet.Services.Impl
{
    public class UserService : GeneralService<UserModel>, IUserService
    {
        private readonly IUserRepository userRepository;

        public UserService(IUserRepository repository)
        {
            this.userRepository = repository;
        }
        public override async Task<UserModel> Add(UserModel model)
        {
            ValidateUser(model);
            await userRepository.AddAsync(model);
            return model;
        }

        private void ValidateUser(UserModel newUser)
        {
            if (newUser == null)
            {
                throw new BadRequest(Warning.InvalidUser);
            }
            if (string.IsNullOrWhiteSpace(newUser.Username))
            {
                throw new BadRequest(Warning.InvalidUserName);
            }
            if (string.IsNullOrWhiteSpace(newUser.Email))
            {
                throw new BadRequest(Warning.InvalidEmail);
            }
            if (string.IsNullOrWhiteSpace(newUser.Password))
            {
                throw new BadRequest(Warning.InvalidPassword);
            }
            if (!string.IsNullOrWhiteSpace(newUser.Email) && userRepository.EmailExists(newUser.Email))
            {
                throw new BadRequest(Warning.EmailExists);
            }
        }

    }       
}
