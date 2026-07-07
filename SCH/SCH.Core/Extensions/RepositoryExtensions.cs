namespace SCH.Core.Extensions
{
    using Microsoft.Extensions.DependencyInjection;
    using SCH.Repositories.Auth;
    using SCH.Repositories.Courses;
    using SCH.Repositories.IdentityUsers;
    using SCH.Repositories.StudentCourseMap;
    using SCH.Repositories.Students;
    using SCH.Repositories.Teachers;
    using SCH.Repositories.Users;

    /// <summary>
    /// Extension methods for configuring repository services
    /// </summary>
    public static class RepositoryExtensions
    {
        /// <summary>
        /// Registers all repository implementations
        /// </summary>
        /// <param name="services">Service collection</param>
        public static void AddRepositories(this IServiceCollection services)
        {
            services.AddScoped<IRefreshTokenRepository, RefreshTokenRepository>();
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<IStudentsRepository, StudentsRepository>();
            services.AddScoped<IIdentityUsersRepository, IdentityUsersRepository>();
            services.AddScoped<ICoursesRepository, CoursesRepository>();
            services.AddScoped<ITeachersRepository, TeachersRepository>();
            services.AddScoped<IStudentCourseMapRepository, StudentCourseMapRepository>();
        }
    }
}

