using System.ComponentModel.DataAnnotations;

namespace HospitalSystem.Dtos
{
    public class EmployeeDto
    {
        public int Id { get; set; }

        public string FullName { get; set; }
        
        public string Ssn { get; set; }

        public string Age { get; set; }

        public int DepartmentId { get; set; }

        public string Name { get; set; }
    }
}
