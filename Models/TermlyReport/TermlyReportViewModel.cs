namespace SchoolManagementApplication.Models.TermlyReport
{
    public class TermlyReportViewModel
    {
        public int StudentId { get; set; }
        public int ClassId { get; set; }
        public int SubjectId { get; set; }
        public string Grade { get; set; }
        public bool Approved { get; set; }
    }
}
