using SchoolManagementApplication.Context;
using SchoolManagementApplication.Entities;
using SchoolManagementApplication.Repository.Interfaces;

namespace SchoolManagementApplication.Repository.Implementations
{
    public class AnnouncementRepository : BaseRepository<Announcement>, IAnnouncementRepository
    {
        public AnnouncementRepository(SchoolDBContext context) : base(context)
        {
        }
    }
}
