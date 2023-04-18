namespace SchoolManagementApplication.Models.Announcement
{
    public class CreateAnnouncementViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Content { get; set; }
        public DateTime DateCreated { get; set; }
    }
}
