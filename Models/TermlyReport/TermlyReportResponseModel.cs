namespace SchoolManagementApplication.Models.TermlyReport
{
    public class TermlyReportResponseModel : BaseResponseModel
    {
        public TermlyReportViewModel Data { get; set; }
    }
    public class TermlyReportsResponseModel : BaseResponseModel
    {
        public List<TermlyReportViewModel> Data { get; set; }
    }
}
