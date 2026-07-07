namespace SCH.Core.Extensions
{
    using Microsoft.Extensions.DependencyInjection;
    using SCH.Services.Auth;
    using SCH.Services.Courses;
    using SCH.Services.IdentityUsers;
    using SCH.Services.Images;
    using SCH.Services.Students;
    using SCH.Services.Teachers;

    /// <summary>
    /// Extension methods for configuring application services
    /// </summary>
    public static class ServiceExtensions
    {
        /// <summary>
        /// Registers all service implementations
        /// </summary>
        /// <param name="services">Service collection</param>
        public static void AddServices(this IServiceCollection services)
        {
            services.AddScoped<IAuthService, AuthService>();
            services.AddScoped<ITokenService, TokenService>();
            services.AddScoped<ICoursesService, CoursesService>();
            services.AddScoped<IIdentityUsersService, IdentityUsersService>();
            services.AddScoped<IImageService, ImageService>();
            services.AddScoped<IStudentsService, StudentsService>();
            services.AddScoped<ITeachersService, TeachersService>();
        }
    }
}

