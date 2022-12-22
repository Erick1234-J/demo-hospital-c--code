using System.ComponentModel.DataAnnotations;

namespace HospitalSystem.Models
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string FullName { get; set; }
        [Required]
        public string Ssn { get; set; }

        [Required]
        public string Age { get; set; }

        public int DepartmentId { get; set; }

        public virtual Department? Department { get; set; }
    }
}
