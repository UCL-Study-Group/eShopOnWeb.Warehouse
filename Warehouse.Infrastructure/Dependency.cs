using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Warehouse.Infrastructure.Repositories;
using Warehouse.Infrastructure.Repositories.Interfaces;

namespace Warehouse.Infrastructure;

public static class Dependency
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddScoped(typeof(IDbRepository<>), typeof(PostgresRepository<>));

        return services;
    }
}
