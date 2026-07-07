namespace SCH.Core.Extensions
{
    using Microsoft.Extensions.DependencyInjection;
    using SCH.Repositories.UnitOfWork;

    /// <summary>
    /// Extension methods for configuring Unit of Work services
    /// </summary>
    public static class UnitOfWorkExtensions
    {
        /// <summary>
        /// Registers all Unit of Work implementations
        /// </summary>
        /// <param name="services">Service collection</param>
        public static void AddUnitOfWorks(this IServiceCollection services)
        {
            services.AddScoped<ISCHUnitOfWork, SCHUnitOfWork>();
            services.AddScoped<IIdentityUnitOfWork, IdentityUnitOfWork>();
        }
    }
}

