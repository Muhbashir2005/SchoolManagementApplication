using System.Security.Cryptography.X509Certificates;

namespace SchoolManagementApplication.Entities
{
    public abstract class User : BaseEntity
    {
        //User - Represents a user of the school management application. This entity will have properties such as user ID, username, password, and the role of the user (e.g. student, teacher, admin).
        public string Password { get; set; }
        public string Email { get; set; }
        public int RoleId { get; set; }
        public string Gender { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Address { get; set; }
        public DateTime DateJoined { get; set; }
        public int PhoneNumber { get; set; }
    }
}
