namespace SchoolManagementApplication.Models.Student
{
    public class UpdateStudentViewModel
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public int RoleId { get; set; }
        public string Address { get; set; }
        public int PhoneNumber { get; set; }
        public int ClassId { get; set; }
        public int DepartmentId { get; set; }
    }
}
