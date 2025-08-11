

using Domain.Entities;
using Domain.Ports.Repositories;
using Infra.Data.Context;

namespace Infra.Data.Repositories;

public class UserRepository : IUserRepository
{
    private readonly InMemoryContext _context;

    public UserRepository(InMemoryContext context)
    {
        _context = context;
    }

    public Task Delete(Guid Id)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<User>> GetAll()
    {
        throw new NotImplementedException();
    }

    public Task Insert(User user)
    {
        throw new NotImplementedException();
    }

    public Task Update(User user)
    {
        throw new NotImplementedException();
    }
}
