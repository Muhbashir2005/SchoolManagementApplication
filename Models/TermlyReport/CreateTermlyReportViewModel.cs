namespace SchoolManagementApplication.Models.TermlyReport
{
    public class CreateTermlyReportViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int StudentId { get; set; }
        public int ClassId { get; set; }
        public int SubjectId { get; set; }
        public string Grade { get; set; }
    }
}
