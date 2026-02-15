using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Global.Infrastructure.Persistence.Db;

using Global.Domain.Ports;
using Global.Infrastructure.Persistence.Repository;

namespace Global.Infrastructure.Persistence.DependencyInjection;

public static class PersistenceModule
{
    public static IServiceCollection AddPersistence(
        this IServiceCollection services,
        IConfiguration configuration)
    {
        // DbContext
        services.AddDbContext<GlobalDbContext>();

        // Repositories (implementações das PORTS)
        services.AddScoped<IDeviceRepository, DeviceRepository>();

        return services;
    }
}