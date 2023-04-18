namespace SchoolManagementApplication.Models.TermlyReport
{
    public class UpdateTermlyReportViewModel
    {
        public string Name { get; set; }
        public int StudentId { get; set; }
        public int ClassId { get; set; }
        public int SubjectId { get; set; }
        public string Grade { get; set; }
        public bool Approved { get; set; }
    }
}
