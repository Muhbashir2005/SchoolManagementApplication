using Microsoft.AspNetCore.Mvc.Rendering;
using SchoolManagementApplication.Entities;
using SchoolManagementApplication.Models;
using SchoolManagementApplication.Models.Department;
using SchoolManagementApplication.Repository.Interfaces;
using System.Linq.Expressions;

namespace SchoolManagementApplication.Services.Implementations
{
    public class DepartmentService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public DepartmentService(
            IUnitOfWork unitOfWork,
            IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
            _unitOfWork = unitOfWork;
        }

        public BaseResponseModel CreateDepartment(CreateDepartmentViewModel request)
        {
            var response = new BaseResponseModel();
            var createdBy = _httpContextAccessor.HttpContext.User.Identity.Name;

            var departmentExist = _unitOfWork.Department.Exists(c => c.Name == request.Name);

            if (departmentExist)
            {
                response.Message = "Department already exist!";
                return response;
            }

            if (string.IsNullOrWhiteSpace(request.Name))
            {
                response.Message = "Department name is required!";
                return response;
            }

            var department = new Department
            {
                Name = request.Name,
                Description = request.Description
            };

            try
            {
                _unitOfWork.Department.Create(department);
                _unitOfWork.SaveChanges();
                response.Status = true;
                response.Message = "Department created successfully.";

                return response;
            }
            catch (Exception ex)
            {
                response.Message = $"Failed to create department at this time: {ex.Message}";
                return response;
            }
        }

        public BaseResponseModel DeleteDepartment(int departmentId)
        {
            var response = new BaseResponseModel();
            var departmentExist = _unitOfWork.Department.Exists(d => d.Id == departmentId);

            if (!departmentExist)
            {
                response.Message = "Department does not exist.";
                return response;
            }

            var department = _unitOfWork.Department.Get(departmentId);

            try
            {
                _unitOfWork.Department.Update(department);
                _unitOfWork.SaveChanges();
                response.Status = true;
                response.Message = "Department successfully deleted.";

                return response;
            }
            catch (Exception ex)
            {
                response.Message = $"Can not delete Department: {ex.Message}";
                return response;
            }
        }

        public DepartmentResponseModel GetAllCategory()
        {
            var response = new CategoriesResponseModel();

            try
            {
                Expression<Func<Category, bool>> expression = c => c.IsDeleted == false;
                var category = _unitOfWork.Categories.GetAll(expression);

                if (category is null || category.Count == 0)
                {
                    response.Message = "No categories found!";
                    return response;
                }

                response.Data = category.Select(
                    category => new CategoryViewModel
                    {
                        Id = category.Id,
                        Name = category.Name,
                        Description = category.Description
                    }).ToList();
            }
            catch (Exception ex)
            {
                response.Message = ex.Message;
                return response;
            }

            response.Status = true;
            response.Message = "Success";

            return response;
        }

        public CategoryResponseModel GetCategory(string categoryId)
        {
            var response = new CategoryResponseModel();

            Expression<Func<Category, bool>> expression = c =>
                                                (c.Id == categoryId)
                                                && (c.Id == categoryId
                                                && c.IsDeleted == false);

            var categoryExist = _unitOfWork.Categories.Exists(expression);

            if (!categoryExist)
            {
                response.Message = $"Category with id {categoryId} does not exist.";
                return response;
            }

            var category = _unitOfWork.Categories.Get(categoryId);

            response.Message = "Success";
            response.Status = true;
            response.Data = new CategoryViewModel
            {
                Id = category.Id,
                Name = category.Name,
                Description = category.Description
            };

            return response;
        }

        public BaseResponseModel UpdateCategory(string categoryId, UpdateCategoryViewModel request)
        {
            var response = new BaseResponseModel();
            string modifiedBy = _httpContextAccessor.HttpContext.User.Identity.Name;
            var categoryExist = _unitOfWork.Categories.Exists(c => c.Id == categoryId);

            if (!categoryExist)
            {
                response.Message = "Category does not exist.";
                return response;
            }

            var category = _unitOfWork.Categories.Get(categoryId);
            category.Description = request.Description;
            category.ModifiedBy = modifiedBy;

            try
            {
                _unitOfWork.Categories.Update(category);
                _unitOfWork.SaveChanges();
                response.Message = "Category updated successfully.";

                return response;
            }
            catch (Exception ex)
            {
                response.Message = $"Could not update the category: {ex.Message}";
                return response;
            }
        }

        public IEnumerable<SelectListItem> SelectCategories()
        {
            return _unitOfWork.Categories.SelectAll().Select(cat => new SelectListItem()
            {
                Text = cat.Name,
                Value = cat.Id
            });
        }
    }
}
