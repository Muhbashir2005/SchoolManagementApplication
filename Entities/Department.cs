namespace SchoolManagementApplication.Entities
{
    public class Department : BaseEntity
    {
        public ICollection<Teacher> Teachers { get; set; } = new List<Teacher>();
        public ICollection<Student> Students { get; set; } = new HashSet<Student>();
        public ICollection<Subject> Subjects { get; set; } = new HashSet<Subject>();
        public string Description { get; set; }
    }
}