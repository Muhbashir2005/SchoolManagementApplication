namespace SchoolManagementApplication.Entities
{
    public class Teacher : BaseEntity 
    {
        public string Email { get; set; }
        public int DepartmentID { get; set; }
        public string Gender { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Address { get; set; }
        public List<Classes> Classes { get; set; } = new List<Classes>();
        public bool IsClassTeacher { get; set; }
        public Role Role { get; set; }
        public ICollection<Subject> Subjects { get; set; } = new HashSet<Subject>();
        public int ClassId { get; set; }
    }
}
