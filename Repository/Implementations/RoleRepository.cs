using SchoolManagementApplication.Context;
using SchoolManagementApplication.Entities;
using SchoolManagementApplication.Repository.Interfaces;

namespace SchoolManagementApplication.Repository.Implementations
{
    public class RoleRepository : BaseRepository<Role>, IRoleRepository
    {
        public RoleRepository(SchoolDBContext context) : base(context)
        {
        }
    }
}
