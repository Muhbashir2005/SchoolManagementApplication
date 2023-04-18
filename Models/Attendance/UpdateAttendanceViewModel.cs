namespace SchoolManagementApplication.Models.Attendance
{
    public class UpdateAttendanceViewModel
    {
        public int StudentId { get; set; }
        public bool IsPresent { get; set; }
        public DateTime DateUpdated { get; set; }
    }
}
