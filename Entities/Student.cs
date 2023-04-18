namespace SchoolManagementApplication.Entities
{
    public class Student : User
    {
        public int Age { get; set; }
        public int ClassId { get; set; }
        public string ParentName { get; set; }
        public string ParentEmail { get; set; }
        public string ParentPhoneNumber { get; set; }
        public int DepartmentId { get; set; }
        public ICollection<Subject> Subjects { get; set; } = new HashSet<Subject>();
        public ICollection<TermlyReport> Reports { get; set; }
    }
}
