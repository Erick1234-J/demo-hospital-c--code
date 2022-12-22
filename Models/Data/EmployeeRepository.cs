namespace HospitalSystem.Models.Data
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly HospitalDbContext _context;

        public EmployeeRepository(HospitalDbContext context)
        {
            _context = context;
        }
        public void CreateEmployee(Employee employee)
        {
            _context.Employees.Add(employee);
            _context.SaveChanges();
        }

        public Department GetDepartment(int id)
        {
           var department = _context.Departments.FirstOrDefault(x => x.Id == id);

           return department;
        }

        public IEnumerable<Department> GetDepartments()
        {
            return _context.Departments.ToList();
        }

        public Employee GetEmployee(int id)
        {
          var employee = _context.Employees.SingleOrDefault(x => x.Id == id);
            return employee;
        }

        public IEnumerable<Employee> GetEmployees()
        {
            return _context.Employees.ToList();

        }
    }
}
