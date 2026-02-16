using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using OneGlobal.Infrastructure.Persistence.Db;

using OneGlobal.Domain.Ports;
using OneGlobal.Infrastructure.Persistence.Db;
using OneGlobal.Infrastructure.Persistence.Repository;
using OneGlobal.Infrastructure.Persistence.Abstractions;

namespace OneGlobal.Infrastructure.Persistence.DependencyInjection;

public static class PersistenceModule
{
    public static IServiceCollection AddPersistence(
        this IServiceCollection services,
        IConfiguration configuration)
    {
        // DbContext
        services.AddDbContext<OneGlobalDbContext>();

        // Repositories (Ports and Adapters Implementations)
        services.AddScoped<IOneGlobalDbContext>(sp => sp.GetRequiredService<OneGlobalDbContext>());
        services.AddScoped<IDeviceRepository, DeviceRepository>();

        return services;
    }
}