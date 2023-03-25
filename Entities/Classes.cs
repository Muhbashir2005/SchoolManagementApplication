namespace SchoolManagementApplication.Entities
{
    public class Classes : BaseEntity
    {
        public ICollection<Student> Students { get; set; } = new HashSet<Student>();
        public int DepartmentId { get; set; }
        public ICollection<Subject> Subjects { get; set; } = new HashSet<Subject>();
        public ICollection<Teacher> Teachers { get; set; } = new HashSet<Teacher>();
    }
}
