
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

    public async Task AddNewUserAsync(User user)
    {
        try
        {
            await _userRepository.InsertAsync(user);
            _emailservice.SendEmail("example@example.com", "example@example.com", "user created", "Api Report");
        }
        catch (Exception ex)
        {

            throw ex;
        }
    }

    public async Task DeleteUserAsync(Guid id)
    {
        try
        {
            await _userRepository.DeleteAsync(id);
            _emailservice.SendEmail("example@example.com", "example@example.com", "user deleted", "Api Report");
        }
        catch (Exception ex)
        {

            throw ex;
        }
    }

    public async Task<IEnumerable<User>> GetAllUsersAsync()
    {
        try
        {
            return await _userRepository.GetAllAsync();
        }
        catch (Exception ex)
        {

            throw ex;
        }
    }

    public async Task UpdateUserAsync(User user)
    {
        try
        {
            await _userRepository.UpdateAsync(user);
            _emailservice.SendEmail("example@example.com", "example@example.com", "user updated", "Api Report");
        }
        catch (Exception ex)
        {

            throw ex;
        }
    }
}
