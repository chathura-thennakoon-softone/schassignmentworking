namespace SCH.Services.Courses
{
    using SCH.Models.StudentCourseMap.Entities;
    using SCH.Models.Courses.ClientDtos;
    using SCH.Models.Courses.Entities;
    using SCH.Repositories.Courses;
    using SCH.Repositories.UnitOfWork;
    using SCH.Shared.Exceptions;

    public class CoursesService: ICoursesService
    {
        private readonly ISCHUnitOfWork unitOfWork;
        private readonly ICoursesRepository coursesRepository;


        public CoursesService(
            ISCHUnitOfWork unitOfWork,
            ICoursesRepository coursesRepository) 
        { 
            this.unitOfWork = unitOfWork;
            this.coursesRepository = coursesRepository;
        }

        public async Task<List<CourseDto>> GetCoursesAsync()
        {
            List<Course> courses = await coursesRepository
                .GetCoursesAsync();

            return courses.Select(MapToDto).ToList();
        }

        public async Task<CourseDto?> GetCourseAsync(int id)
        {
            Course? course = await coursesRepository.GetCourseAsync(id);
            return course == null ? null : MapToDto(course);
        }


        public async Task<int> InsertCourseAsync(CourseDto course)
        {
            Course courseEntity = new Course
            {
                Id = 0,
                Name = course.Name,
                StudentCourseMaps = new List<StudentCourseMap>()
            };

            await coursesRepository.InsertCourseAsync(courseEntity);
            await unitOfWork.SaveChangesAsync();

            return courseEntity.Id;
        }

        public async Task UpdateCourseAsync(CourseDto course)
        {
            Course? courseEntity = await coursesRepository
                .GetCourseAsync(course.Id);

            if (courseEntity == null)
            {
                throw SCHDomainException.NotFound();
            }

            // Map DTO to entity
            courseEntity.Name = course.Name;
            // Include RowVersion from frontend for concurrency check
            courseEntity.RowVersion = course.RowVersion ?? courseEntity.RowVersion;

            // Repository handles concurrency check
            coursesRepository.UpdateAsync(courseEntity);
            await unitOfWork.SaveChangesAsync();
        }

        public async Task DeleteCourseAsync(int id)
        {
            await coursesRepository
                .DeleteCourseAsync(id);

            await unitOfWork.SaveChangesAsync();
        }

        private static CourseDto MapToDto(Course c) => new CourseDto
        {
            Id = c.Id,
            Name = c.Name,
            RowVersion = c.RowVersion
        };
    }
}
