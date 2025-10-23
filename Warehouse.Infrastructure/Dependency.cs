using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Warehouse.Infrastructure.Models;
using Warehouse.Infrastructure.Repositories;
using Warehouse.Infrastructure.Repositories.Interfaces;

namespace Warehouse.Infrastructure;

public static class Dependency
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
    {
        services.Configure<DbCredentials>(options =>
        {
            options.ConnectionString = configuration.GetConnectionString("DefaultConnection")
            ?? "Host=warehouse-db;Port=5432;Database=warehouse_db;Username=warehouse_user;Password=warehouse_pass";
        });

        services.AddScoped(typeof(IDbRepository<>), typeof(PostgresRepository<>));

        return services;
    }
}
