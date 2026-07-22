namespace SCH.Core.Extensions
{
    using Microsoft.Extensions.DependencyInjection;
    using SCH.Shared.HttpContext;

    /// <summary>
    /// Extension methods for configuring HttpContext-related services
    /// </summary>
    public static class HttpContextExtensions
    {
        /// <summary>
        /// Registers HttpContext-related services
        /// </summary>
        /// <param name="services">Service collection</param>
        public static void AddHttpContextServices(this IServiceCollection services)
        {
            services.AddHttpContextAccessor();
            services.AddSingleton<IUserInfo, UserInfo>();
            services.AddSingleton<IRouteInfo, RouteInfo>();

            /* 
             6. IQ Issue | Runtime | Critical
             Should be singleton

            services.AddScoped<IUserInfo, UserInfo>();
            services.AddScoped<IRouteInfo, RouteInfo>();
             
             */


        }
    }
}

