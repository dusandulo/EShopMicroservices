using Microsoft.Extensions.DependencyInjection;

namespace Ordering.Application
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddAplicationServices(this IServiceCollection services)
        {
            //services.AddMediatR(cfg =>{
            //      cfg.RegisterServicesFromAssembly(Assembly.GeExecutingAssembly());
            //});

            return services;
        }
    }
}
