namespace SchoolManagementApplication.Entities
{
    public class Announcement : BaseEntity
    {
        public string Title { get; set; }
        public string content { get; set; }
        public DateTime DateCreated { get; set; }
    }
}
