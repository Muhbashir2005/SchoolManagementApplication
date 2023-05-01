using Mysqlx.Crud;
using SchoolManagementApplication.Models;
using SchoolManagementApplication.Models.Announcement;

namespace SchoolManagementApplication.Services.Interfaces
{
    public interface IAnnouncementService 
    {
        BaseResponseModel Create(CreateAnnouncementViewModel request);
        BaseResponseModel Update(UpdateAnnouncementViewModel request);
        BaseResponseModel Delete(int announcementid);
        AnnouncementResponseModel GetAnnouncement(int announcementid);
        AnnouncementResponseModel DisplayAnnouncement();
    }
}
