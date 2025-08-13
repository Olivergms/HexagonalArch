
using Domain.Entities;

namespace Domain.Ports.Repositories;

public interface IUserRepository
{
    Task<IEnumerable<User>> GetAllAsync();
    Task InsertAsync(User user);
    Task UpdateAsync(User user);
    Task DeleteAsync(Guid Id);
}
