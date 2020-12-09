using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace Data
{
    public static class ApplicationModule
    {
        public static IServiceCollection AddMyAppRepository(this IServiceCollection services)
        {
            Assembly appServiceAssembly = Assembly.GetExecutingAssembly();
            services.Scan(scan => scan
                .FromAssemblies(appServiceAssembly)
                .AddClasses(classes => classes.Where(t => t.Name.EndsWith("Repository", StringComparison.OrdinalIgnoreCase)))
                .AsImplementedInterfaces()
                .WithTransientLifetime());//注册的生命周期为 Transient
            return services;
        }
    }
}
