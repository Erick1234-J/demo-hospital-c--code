using System.ComponentModel.DataAnnotations;

namespace HospitalSystem.Models
{
    public class Department
    {
        public Department()
        {
            Employees = new HashSet<Employee>();
        }
       

        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public string Location { get; set; }

        public string School { get; set; }

        public virtual ICollection<Employee> Employees { get; set; }
    }
}
