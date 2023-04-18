namespace SchoolManagementApplication.Models.Attendance
{
    public class CreateAttendanceViewModel
    {
        public int StudentId { get; set; }
        public DateTime DateCreated { get; set; }
        public bool IsPresent { get; set; }
        public DateTime DateUpdated { get; set; }
    }
}
