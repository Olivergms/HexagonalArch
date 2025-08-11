
using Domain.Entities;

namespace Domain.Ports.Repositories;

public interface IUserRepository
{
    Task<IEnumerable<User>> GetAll();
    Task Insert(User user);
    Task Update(User user);
    Task Delete(Guid Id);
}
