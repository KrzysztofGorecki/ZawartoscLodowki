using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using ZawartoscLodowki.Application.Contracts;
using ZawartoscLodowki.Persistance.DatabaseContext;
using ZawartoscLodowki.Persistance.Repositories;

namespace ZawartoscLodowki.Persistance;

public static class PersistenceServiceRegistration
{
    public static IServiceCollection AddPersistenceServices(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<AppDbContext>(options=> 
            options.UseSqlServer(configuration.GetConnectionString("DefaultConnection"))
        );
        services.AddScoped(typeof(GenericRepository<>),typeof(GenericRepository<>));
        
        services.AddScoped<IMeasureUnitRepository, MeasureUnitRepository>();
        services.AddScoped<IAssortmentKindRepository, AssortmentKindRepository>();
        services.AddScoped<IAssortmentRepository, AssortmentRepository>();
        
        return services;
    }
}