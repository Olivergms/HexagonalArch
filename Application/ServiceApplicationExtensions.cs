

using Application.Services;
using Domain.Ports.Services;
using Microsoft.Extensions.DependencyInjection;

namespace Application;

public static class ServiceApplicationExtensions
{
    public static IServiceCollection ApplicationService(this IServiceCollection services)
    {
        services.AddTransient<IUserService, UserServiceManager>();

        return services;
    }
}
