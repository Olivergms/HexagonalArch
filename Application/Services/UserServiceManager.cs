
using Domain.Entities;
using Domain.Ports.Repositories;
using Domain.Ports.Services;

namespace Application.Services;

public class UserServiceManager : IUserService
{
    private readonly IEmailService _emailservice;
    private readonly IUserRepository _userRepository;

    public UserServiceManager(IEmailService emailservice, IUserRepository userRepository)
    {
        _emailservice = emailservice;
        _userRepository = userRepository;
    }

    public Task AddNewUserAsync(User user)
    {
        throw new NotImplementedException();
    }

    public Task DeleteUserAsync(Guid id)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<User>> GetAllUsersAsync()
    {
        throw new NotImplementedException();
    }

    public Task UpdateUserAsync(User user)
    {
        throw new NotImplementedException();
    }
}
