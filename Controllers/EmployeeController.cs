using HospitalSystem.Conventions;
using HospitalSystem.Dtos;
using HospitalSystem.Models;
using HospitalSystem.Models.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HospitalSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeRepository _employeeRepository;

        public EmployeeController(IEmployeeRepository  employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }

        [HttpGet]

        public ActionResult<IEnumerable<EmployeeDto>> GetEmployees()
        {
            var employees = _employeeRepository.GetEmployees();
            var departments = _employeeRepository.GetDepartments();

            if (employees == null || departments == null)
            {
                return NotFound();
            }else
            {
                var employeeDto = employees.ConvertToDto(departments);
                //var employeeDto = from employee in employees
                  //                join department in departments on employee.DepartmentId equals department.Id
                    //              select new EmployeeDto
                      //            {
                        //              Id = employee.Id,
                          //            FullName = employee.FullName,
                            //          Ssn = employee.Ssn,
                              //        Age = employee.Age,
                                //      DepartmentId = employee.DepartmentId,
                                  //    Name = department.Name
                                  //};

                return Ok(employeeDto);
            }

           
        }

        [HttpGet("{id}")]

        public ActionResult<EmployeeDto> GetEmployee(int id)
        {
            var employee = _employeeRepository.GetEmployee(id);

            if (employee == null)
            {
                return NotFound();
            }else
            {
                var department = _employeeRepository.GetDepartment(employee.DepartmentId);
                var employeeDto = employee.ConvertToDto(department);
                //var employeeDto = new EmployeeDto
                //{
                  //  Id = employee.Id,
                    //FullName = employee.FullName,
                    //Ssn = employee.Ssn,
                    //Age = employee.Age,
                    //DepartmentId = employee.DepartmentId,
                    //Name = department.Name,
                //};

                return Ok(employeeDto);
            }



            
        }

        [HttpPost]
        public ActionResult CreateDepartment(Employee employee)
        {
            _employeeRepository.CreateEmployee(employee);


            return Ok();
        }
    }
}
