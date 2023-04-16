namespace SchoolManagementApplication.Entities
{
    public class Teacher : BaseEntity
    {
        public int DepartmentID { get; set; }
        public ICollection<Classes> ClassesTaught { get; set; } = new List<Classes>();
        public bool IsClassTeacher { get; set; }
        public ICollection<Subject> Subjects { get; set; } = new HashSet<Subject>();
        public int ClassId { get; set; }
    }
}
