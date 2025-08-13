

using Domain.Entities;
using Domain.Ports.Repositories;
using Infra.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace Infra.Data.Repositories;

public class UserRepository : IUserRepository
{
    private readonly InMemoryContext _context;

    public UserRepository(InMemoryContext context)
    {
        _context = context;
    }

    public async Task DeleteAsync(Guid Id)
    {
        var user = await _context.Users.FirstOrDefaultAsync(x => x.Id == Id);
        if (user == null) 
            throw new Exception("User not found");

        _context.Users.Remove(user);

        await _context.SaveChangesAsync();
    }

    public async Task<IEnumerable<User>> GetAllAsync()
    {
        return await _context.Users.AsNoTracking().ToListAsync();
    }

    public async Task InsertAsync(User user)
    {
        await _context.Users.AddAsync(user);
        await _context.SaveChangesAsync();
    }

    public async Task UpdateAsync(User user)
    {
        var userFromDb = await _context.Users.FirstOrDefaultAsync(u => u.Id == user.Id);

        if (userFromDb == null) throw new Exception("User not found");

        _context.Entry(userFromDb).CurrentValues.SetValues(user);

        await _context.SaveChangesAsync();

    }
}
