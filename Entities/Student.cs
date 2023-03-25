namespace SchoolManagementApplication.Entities
{
    public class Student : BaseEntity
    {
        public DateTime DateOfBirth { get; set; }
        public int Age { get; set; }
        public int ClassId { get; set; }
        public string Address { get; set; }
        public string Gender { get; set; }
        public string ParentName { get; set; }
        public string ParentEmail { get; set; }
        public string ParentPhoneNumber { get; set; }
        public int DepartmentId { get; set; }
        public ICollection<Subject> Subjects { get; set; } = new HashSet<Subject>();

        public DateTime DateJoined { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
    }
}
