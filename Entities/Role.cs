namespace SchoolManagementApplication.Entities
{
    public class Role : BaseEntity
    {
        public string Description { get; set; }
        public ICollection<Staff> Staffs { get; set; } = new HashSet<Staff>();
        public DateTime CreatedOn { get; set; }
    }
}
