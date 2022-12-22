using Microsoft.EntityFrameworkCore;

namespace HospitalSystem.Models.Data
{
    public class DepartmentRepository : IDepartmentRepository
    {
        private readonly HospitalDbContext _context;

        public DepartmentRepository(HospitalDbContext context)
        {
            _context = context;
        }
        public void CreateDepartment(Department department)
        {
               _context.Departments.Add(department);
               _context.SaveChanges();

            
        }

        public Department GetDepartmentById(int id)
        {
           
          var department =  _context.Departments.Find(id);

          return department;
        }

        public IEnumerable<Department> GetDepartments()
        {
            var departments =  _context.Departments.ToList();
            return departments;
        }
    }
}
