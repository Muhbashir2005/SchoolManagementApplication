namespace SchoolManagementApplication.Entities
{
    public class Role : BaseEntity
    {
        public string Description { get; set; }
        public ICollection<Users> Staffs { get; set; } = new HashSet<Staff>();
        public DateTime DateCreated { get; set; }
    }
}
