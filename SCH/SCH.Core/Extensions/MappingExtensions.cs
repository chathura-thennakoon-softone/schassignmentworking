namespace SCH.Core.Extensions
{
    using Microsoft.Extensions.DependencyInjection;
    using SCH.Mappings.Courses;
    using SCH.Mappings.Students;
    using SCH.Mappings.Teachers;

    public static class MappingExtensions
    {
        public static void AddMappings(this IServiceCollection services)
        {
            services.AddAutoMapper(cfg =>
            {
                cfg.AddProfile<CourseProfile>();
                cfg.AddProfile<StudentProfile>();
                cfg.AddProfile<TeacherProfile>();
            });
        }
    }
}


