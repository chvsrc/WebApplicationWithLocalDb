using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace AspMvcWebApplication.ViewModels.Employees
{
    public class EmployeeViewModel
    {
        [Required]
        [Range(typeof(int), "1", "9999999")]
        [DisplayName("Employee Id")]
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; } = string.Empty;

        [Required]
        [DisplayName("Department Id")]
        public int DepartmentId { get; set; }

        public string Address { get; set; } = string.Empty;

        public int Salary { get; set; }

        public string? Email { get; set; }

    }
}
