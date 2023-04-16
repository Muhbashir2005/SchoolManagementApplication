using SchoolManagementApplication.Context;
using SchoolManagementApplication.Entities;
using SchoolManagementApplication.Repository.Interfaces;

namespace SchoolManagementApplication.Repository.Implementations
{
    public class TermlyReportRepository : BaseRepository<TermlyReport>, ITermlyReportRepository
    {
        public TermlyReportRepository(SchoolDBContext context) : base(context)
        {
        }
    }
}
