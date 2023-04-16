using SchoolManagementApplication.Repository.Interfaces;
using SchoolManagementApplication.Entities;
using SchoolManagementApplication.Context;

namespace SchoolManagementApplication.Repository.Implementations
{
    public class ClassRepository : BaseRepository<Classes>, IClassRepository
    {
        public ClassRepository(SchoolDBContext context) : base(context)
        {
        }
    }
}
