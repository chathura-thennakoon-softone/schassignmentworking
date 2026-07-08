namespace SCH.Services.Dashboard
{
    using SCH.Models.Dashboard;

    public interface IDashboardService
    {
        Task<List<CourseStudentCountDto>> GetCourseStudentCountAsync();
    }
}
