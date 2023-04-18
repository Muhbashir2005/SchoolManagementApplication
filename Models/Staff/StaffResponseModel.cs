namespace SchoolManagementApplication.Models.Staff
{
    public class StaffResponseModel : BaseResponseModel
    {
        public StaffViewModel Data { get; set; }
    }
    public class StaffsResponseModel : BaseResponseModel
    {
        public List<StaffViewModel> Data { get; set; }
    }
}
