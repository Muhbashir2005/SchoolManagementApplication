using SchoolManagementApplication.Context;
using SchoolManagementApplication.Entities;
using SchoolManagementApplication.Repository.Interfaces;

namespace SchoolManagementApplication.Repository.Implementations
{
    public class DepartmentRepository : BaseRepository<Department>, IDepartmentRepository
    {
        public DepartmentRepository(SchoolDBContext context) : base(context)
        {
        }
    }
}
