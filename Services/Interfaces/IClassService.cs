using Microsoft.AspNetCore.Mvc.Rendering;
using SchoolManagementApplication.Models;
using SchoolManagementApplication.Models.Class;

namespace SchoolManagementApplication.Services.Interfaces
{
    public interface IClassService
    {
        BaseResponseModel CreateClass(CreateClassViewModel request);
        BaseResponseModel DeleteClass(int classId);
        BaseResponseModel UpdateClass(int classId, UpdateClassViewModel request);
        ClassResponseModel GetClass(int classId);
        ClassResponseModel GetAllClass();
        IEnumerable<SelectListItem> SelectClasses(); //The SelectListItem is rendered  with the HTML <option> element with the specified attribute values
    }
}
