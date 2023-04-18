namespace SchoolManagementApplication.Models.Class
{
    public class CreateClassViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int DepartmentId { get; set; }
        public string Description { get; set; }
        public DateTime DateCreated { get; set; }
    }
}
