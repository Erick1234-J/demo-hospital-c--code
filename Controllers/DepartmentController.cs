using HospitalSystem.Dtos;
using HospitalSystem.Models;
using HospitalSystem.Models.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HospitalSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartmentController : ControllerBase
    {
        private readonly IDepartmentRepository _departmentRepository;

        public DepartmentController(IDepartmentRepository departmentRepository)
        {
            _departmentRepository = departmentRepository;
        }

        [HttpGet]
        public ActionResult<IEnumerable<DepartmentDto>> GetDepartments()
        {
           

            var departments = _departmentRepository.GetDepartments();

            var deptDto = from department in departments
                          select new DepartmentDto
                          {
                              Id = department.Id,
                              Name = department.Name,
                              Location = department.Location,
                              School = department.School
                          };

            return Ok(deptDto);
        }

        [HttpGet("{id}")]

        public ActionResult<DepartmentDto> GetDepartmentById(int id)
        {
            var department = _departmentRepository.GetDepartmentById(id);

            if(department == null)
            {
                return NotFound();
            }

            var deptDtos = new DepartmentDto
            {
                Id = department.Id,
                Name = department.Name,
                Location = department.Location,
                School = department.School
            };
            return Ok(deptDtos);
        }
    }
}
