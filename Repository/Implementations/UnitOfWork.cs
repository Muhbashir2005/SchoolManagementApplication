using SchoolManagementApplication.Context;
using SchoolManagementApplication.Repository.Interfaces;

namespace SchoolManagementApplication.Repository.Implementations
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly SchoolDBContext _context;
        // No Understanding of the next line
        private bool _disposed = false;
        public IAnnouncementRepository Announcement { get; }
        public IAttendanceRepository Attendance { get; }
        public IClassRepository Class { get; }
        public IDepartmentRepository Department { get; }
        public IRoleRepository Role { get; }
        public IStaffRepository Staff { get; }
        public IStudentRepository Student { get; }
        public ISubjectRepository Subject { get; }
        public ITeacherRepository Teacher { get; }
        public ITermlyReportRepository TermlyReport { get; }

        public UnitOfWork(
            SchoolDBContext context,
            IAnnouncementRepository announcementRepository,
            IClassRepository classRepository,
            IDepartmentRepository departmentRepository,
            IRoleRepository roleRepository,
            IStaffRepository staffRepository,
            IStudentRepository studentRepository,
            ISubjectRepository subjectRepository,
            ITeacherRepository teacherRepository,
            ITermlyReportRepository termlyReportRepository
            )
        {
            _context = context;
            Announcement = announcementRepository;  
            Class = classRepository;
            Department = departmentRepository;
            Role = roleRepository;
            Staff = staffRepository;
            Student = studentRepository;
            Subject = subjectRepository;
            Teacher = teacherRepository;
            TermlyReport = termlyReportRepository;
        }
        public int SaveChanges() 
        {
            return _context.SaveChanges();
        }
        protected virtual void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                if (disposing)
                {
                    _context.Dispose();
                }
                _disposed = true;
            }
        }
        // Next Method not understood
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}