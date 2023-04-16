using SchoolManagementApplication.Context;
using SchoolManagementApplication.Entities;
using SchoolManagementApplication.Repository.Interfaces;

namespace SchoolManagementApplication.Repository.Implementations
{
    public class AttendanceRepository : BaseRepository<Attendance>, IAttendanceRepository
    {
        public AttendanceRepository(SchoolDBContext context) : base(context)
        {
        }
    }
}
