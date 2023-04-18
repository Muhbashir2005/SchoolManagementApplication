namespace SchoolManagementApplication.Models.Attendance
{
    public class AttendanceResponseModel : BaseResponseModel
    {
        public AttendanceViewModel Data { get; set; }
    }
    public class AttendancesResponseModel : BaseResponseModel 
    {
        public List<AttendanceViewModel> Data { get; set; }
    }
}
