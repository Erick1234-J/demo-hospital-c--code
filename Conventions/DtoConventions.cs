using HospitalSystem.Dtos;
using HospitalSystem.Models;
using System.Net.WebSockets;

namespace HospitalSystem.Conventions
{
    public static class DtoConventions
    {
        public static EmployeeDto ConvertToDto(this Employee employee, Department department)
        {
            return new EmployeeDto
            {
                Id = employee.Id,
                FullName = employee.FullName,
                Ssn = employee.Ssn,
                Age = employee.Age,
                DepartmentId = employee.DepartmentId,
                Name = department.Name,
            };
        }

        public static IEnumerable<EmployeeDto> ConvertToDto(this IEnumerable<Employee> employees, IEnumerable<Department> departments)
        {
            return (from employee in employees join department in departments on employee.DepartmentId equals department.Id
                    select new EmployeeDto
                    {
                       Id = employee.Id,
                       FullName = employee.FullName,
                       Ssn = employee.Ssn,
                       Age = employee.Age,
                       DepartmentId = employee.DepartmentId,
                       Name = department.Name
                    }).ToList();

            
        }

   
      
    }
}
