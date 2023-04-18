namespace SchoolManagementApplication.Models.Announcement
{
    public class AnnouncementResponseModel : BaseResponseModel
    {
        public AnnouncementViewModel Data { get; set; } 
    }
    public class AnnouncementsViewModel : BaseResponseModel
    {
        public List<AnnouncementViewModel> Data { get; set; }
    }
}
