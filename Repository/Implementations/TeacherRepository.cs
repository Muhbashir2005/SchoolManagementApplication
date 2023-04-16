using SchoolManagementApplication.Context;
using SchoolManagementApplication.Entities;
using SchoolManagementApplication.Repository.Interfaces;

namespace SchoolManagementApplication.Repository.Implementations
{
    public class TeacherRepository : BaseRepository<Teacher>, ITeacherRepository
    {
        public TeacherRepository(SchoolDBContext context) : base(context)
        {
        }
    }
}
