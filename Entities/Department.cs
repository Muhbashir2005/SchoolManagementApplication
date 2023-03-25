namespace SchoolManagementApplication.Entities
{
    public class Department : BaseEntity
    {
        public ICollection<Teacher> Teachers { get; set; } = new HashSet<Teacher>();
        public ICollection<Student> Students { get; set; } = new HashSet<Student>();
        public string Description { get; set; }
    }
}