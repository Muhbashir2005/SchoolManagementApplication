using SchoolManagementApplication.Context;
using SchoolManagementApplication.Entities;
using SchoolManagementApplication.Repository.Interfaces;

namespace SchoolManagementApplication.Repository.Implementations
{
    public class StudentRepository : BaseRepository<Student>, IStudentRepository
    {
        public StudentRepository(SchoolDBContext context) : base(context)
        {
        }
    }
}
