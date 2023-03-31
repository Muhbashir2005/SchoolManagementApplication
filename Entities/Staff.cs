namespace SchoolManagementApplication.Entities
{
    public abstract class Staff : BaseEntity
    {
        public string Email { get; set; }
        public Role Role { get; set; }
        public DateTime DateOfBirth { get; set; }
        public DateTime DateJoined { get; set; }
        public string Password { get; set; }
    }
}
