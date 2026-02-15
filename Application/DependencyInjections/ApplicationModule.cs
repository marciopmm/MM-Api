using AutoMapper;
using Microsoft.Extensions.DependencyInjection;
using Global.Application.Abstractions.Services.DeviceDTOs;
using Global.Application.Services.DeviceDTOs;

namespace Global.Application.DependencyInjection;

public static class ApplicationModule
{
    public static IServiceCollection AddApplication(
        this IServiceCollection services)
    {
        services.AddScoped<IDeviceDtoService, DeviceDtoService>();
        services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

        return services;
    }
}