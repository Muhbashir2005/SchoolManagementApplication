using SchoolManagementApplication.Entities;

namespace SchoolManagementApplication.Repository.Interfaces
{
	public interface IRepository<T> where T : BaseEntity, new()
	{ 
	}
}
