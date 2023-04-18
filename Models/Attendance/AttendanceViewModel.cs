namespace SchoolManagementApplication.Models.Attendance
{
    public class AttendanceViewModel
    {
        public int StudentId { get; set; }
        public string StudentName { get; set; }
        public List<DateTime> Dates { get; set; }
        public Dictionary<DateTime, bool> Attendance { get; set; }
    }
}
