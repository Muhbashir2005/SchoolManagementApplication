namespace SchoolManagementApplication.Entities
{
    public class Department : BaseEntity
    {
        public ICollection<Teacher> Teachers { get; set; } = new List<Teacher>();
        public ICollection<Student> Students { get; set; } = new HashSet<Student>();
        public ICollection<Classes> Classes { get; set; }  = new List<Classes>();
        public string Description { get; set; }
    }
}