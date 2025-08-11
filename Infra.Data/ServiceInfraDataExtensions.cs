
using Domain.Ports.Repositories;
using Infra.Data.Context;
using Infra.Data.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Infra.Data;

public static class ServiceInfraDataExtensions
{
    public static IServiceCollection AddDataBaseInMemory(this IServiceCollection services)
    {
        services.AddDbContext<InMemoryContext>(opt => opt.UseInMemoryDatabase("UsersApp"));
        services.AddTransient<IUserRepository, UserRepository>();
        return services;
    }
}
