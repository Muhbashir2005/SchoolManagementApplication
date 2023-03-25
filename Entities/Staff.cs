namespace SchoolManagementApplication.Entities
{
    public class Staff : BaseEntity
    {
        public string Email { get; set; }
        public Role Role { get; set; }
        public DateTime DateOfBirth { get; set; }
        public DateTime DateJoined { get; set; }
        public string Password { get; set; }
    }
}
