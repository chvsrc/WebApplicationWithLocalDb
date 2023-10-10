using AspMvcWebApplication.Entities;
using AspMvcWebApplication.ViewModels.Employees;

namespace AspMvcWebApplication.Extensions
{
    public static class EmployeeTaskExtensions
    {
        public static Employee ToEntity(this Employee employee, EmployeeViewModel model)
        {
            employee.Id = model.Id;
            employee.Name = model.Name;
            employee.DepartmentId = model.DepartmentId;
            employee.Address = model.Address;
            employee.Salary = model.Salary;
            employee.Email = model.Email;

            return employee;
        }

        public static EmployeeViewModel ToModel(this Employee employee)
        {
            return new EmployeeViewModel()
            {
                Id = employee.Id,
                Name = employee.Name,
                DepartmentId = employee.DepartmentId,
                Address = employee.Address,
                Salary = employee.Salary,
                Email = employee.Email,
            };
        }
    }
}
