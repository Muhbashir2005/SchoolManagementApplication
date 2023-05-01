using Microsoft.AspNetCore.Mvc.Rendering;
using SchoolManagementApplication.Models;
using SchoolManagementApplication.Models.Department;

namespace SchoolManagementApplication.Services.Interfaces
{
    public interface IDepartmentService
    {
        BaseResponseModel CreateDepartment(CreateDepartmentViewModel createCategoryDto);
        BaseResponseModel DeleteDepartment(int departmentId);
        BaseResponseModel UpdateDepartment(int departmentId, UpdateDepartmentViewModel updateCategoryDto);
        DepartmentResponseModel GetDepartment(int departmentId);
        DepartmentResponseModel GetAllDepartment();
        IEnumerable<SelectListItem> SelectDepartments(); //The SelectListItem is rendered  with the HTML <option> element with the specified attribute tag
    }
}
