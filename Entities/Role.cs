namespace SchoolManagementApplication.Entities
{
    public class Role : BaseEntity
    {
        public string Description { get; set; }
        public ICollection<User> User { get; set; } = new HashSet<User>();
        public DateTime DateCreated { get; set; }
    }
}
