namespace SchoolManagementApplication.Entities
{
    public class Subject : BaseEntity
    {
        public string Description { get; set; }
        public ICollection<Classes> Classes { get; set; } = new HashSet<Classes>();
        public ICollection<Teacher> Teachers { get; set; } = new HashSet<Teacher>();
        public int  DepartmentId { get; set; }
    }
}
