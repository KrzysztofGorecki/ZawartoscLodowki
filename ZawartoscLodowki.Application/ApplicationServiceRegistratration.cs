using System.Reflection;
using Microsoft.Extensions.DependencyInjection;

namespace ZawartoscLodowki.Application;

public static class ApplicationServiceRegistratration
{
    public static IServiceCollection AddApplicationService(this IServiceCollection services)
    {
        services.AddAutoMapper(Assembly.GetExecutingAssembly());
        services.AddMediatR(cfg=> cfg.RegisterServicesFromAssemblies(Assembly.GetExecutingAssembly()));
        return services;
    }
}