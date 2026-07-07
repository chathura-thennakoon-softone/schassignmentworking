namespace SCH.Mappings.Courses
{
    using AutoMapper;
    using SCH.Models.Courses.ClientDtos;
    using SCH.Models.Courses.Entities;

    public class CourseProfile : Profile
    {
        public CourseProfile()
        {
            CreateMap<Course, CourseDto>();
        }
    }
}
