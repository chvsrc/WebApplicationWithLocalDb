using System.ComponentModel.DataAnnotations;

namespace AspMvcWebApplication.Entities
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; } = string.Empty;

        public string Address { get; set; } = string.Empty;

        public string? Email { get; set; }

    }
}
