namespace SCH.Core.Extensions
{
    using Microsoft.Extensions.DependencyInjection;
    using SCH.Shared.Utility;

    /// <summary>
    /// Extension methods for configuring utility services
    /// </summary>
    public static class UtilityExtensions
    {
        /// <summary>
        /// Registers all utility implementations
        /// </summary>
        /// <param name="services">Service collection</param>
        public static void AddUtilities(this IServiceCollection services)
        {
            services.AddScoped<IJsonUtility, JsonUtility>();
        }
    }
}

