using SchoolManagementApplication.Context;
using SchoolManagementApplication.Entities;
using SchoolManagementApplication.Repository.Interfaces;

namespace SchoolManagementApplication.Repository.Implementations
{
    public class StaffRepository : BaseRepository<Staff>, IStaffRepository
    {
        public StaffRepository(SchoolDBContext context) : base(context)
        {
        }
    }
}
