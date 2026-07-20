namespace SCH.Core.Extensions
{
    using Microsoft.Extensions.DependencyInjection;
    using SCH.Shared.Cache;

    public static class CacheExtensions
    {
        public static IServiceCollection AddCacheServices(this IServiceCollection services)
        {
            services.AddMemoryCache();

            /*
             14. IQ Issue | Runtime | Critical
             Register CacheService as Singleton
             
             
             */
            services.AddSingleton<ICacheService, CacheService>();


            return services;
        }
    }
}
