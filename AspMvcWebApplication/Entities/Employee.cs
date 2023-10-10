using System.ComponentModel.DataAnnotations;

namespace AspMvcWebApplication.Entities
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; } = string.Empty;

        [Required]
        public int DepartmentId { get; set; }

        public string Address { get; set; } = string.Empty;

        public int Salary { get; set; }

        public string? Email { get; set; }

    }
}
