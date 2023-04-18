namespace SchoolManagementApplication.Models.Teacher
{
    public class TeacherViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public int RoleId { get; set; }
        public string Gender { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Address { get; set; }
        public DateTime DateJoined { get; set; }
        public int PhoneNumber { get; set; }
    }
}
