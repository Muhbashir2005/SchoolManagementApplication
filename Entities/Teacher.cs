namespace SchoolManagementApplication.Entities
{
    public class Teacher : BaseEntity
    {
        public int DepartmentID { get; set; }
        public ICollection<Class> ClassesTaught { get; set; } = new List<Class>();
        public bool IsClassTeacher { get; set; }
        public ICollection<Subject> Subjects { get; set; } = new HashSet<Subject>();
        public int ClassId { get; set; }
    }
}
