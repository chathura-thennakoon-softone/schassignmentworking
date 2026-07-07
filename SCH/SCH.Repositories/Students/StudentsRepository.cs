namespace SCH.Repositories.Students
{
    using Microsoft.EntityFrameworkCore;
    using SCH.Models.Students.Entities;
    using SCH.Repositories.Common;
    using SCH.Repositories.DbContexts;

    public class StudentsRepository : BaseRepository<Student, SCHContext>, IStudentsRepository
    {
        public StudentsRepository(SCHContext context) : base(context)
        {
        }

        public async Task<List<Student>> GetStudentsAsync(bool? isActive)
        {

            List<Student> students = await Context
                .Student
                .AsNoTracking()
                .Where(s => !isActive.HasValue || s.IsActive == isActive)
                .ToListAsync();

            return students;
        }

        public async Task<Student?> GetStudentAsync(int id)
        {
            Student? student = await Context
                .Student
                .AsNoTracking()
                .Include(s => s.StudentCourseMaps)
                .ThenInclude(sc => sc.Course)
                .Include(s => s.User)
                .SingleOrDefaultAsync(s => s.Id == id);

            return student;
        }

        public async Task<Student?> GetStudentByUserIdAsync(int userId)
        {
            return await Context
                .Student
                .AsNoTracking()
                .SingleOrDefaultAsync(s => s.UserId == userId);
        }

        public async Task InsertStudentAsync(Student student)
        {                                     
            await Context.Student.AddAsync(student);
        }

        public void UpdateAsync(Student student)
        {
            UpdateWithConcurrency(student);
        }

        public async Task DeleteStudentAsync(int id)
        {

            Student? studentEntity = await Context
                .Student.SingleOrDefaultAsync(s => s.Id == id);

            if (studentEntity != null)
            {
                Context.Student.Remove(studentEntity);
            }
        }
    }
}
