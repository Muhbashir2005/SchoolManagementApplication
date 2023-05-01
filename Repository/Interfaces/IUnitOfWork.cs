namespace SchoolManagementApplication.Repository.Interfaces
{
    //IDisposable not fully understood
    public interface IUnitOfWork : IDisposable
    {
        IAnnouncementRepository Announcement { get; }
        IAttendanceRepository Attendance { get; }
        IClassRepository Class { get; }
        IDepartmentRepository Department { get; }
        IRoleRepository Role { get; }
        IStaffRepository Staff { get; }
        IStudentRepository Student { get; }
        ISubjectRepository Subject { get; }
        ITeacherRepository Teacher { get; }
        ITermlyReportRepository TermlyReport { get; }
        int SaveChanges();
    }
}
