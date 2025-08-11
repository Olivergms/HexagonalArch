
using Domain.Entities;

namespace Domain.Ports.Services;

public interface IUserService
{
    Task<IEnumerable<User>> GetAllUsersAsync();
    Task AddNewUserAsync(User user);
    Task DeleteUserAsync(Guid id);
    Task UpdateUserAsync(User user);
}
