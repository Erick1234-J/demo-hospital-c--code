namespace HospitalSystem.Models.Data
{
    public interface IEmployeeRepository
    {
        IEnumerable<Employee> GetEmployees();

        IEnumerable<Department> GetDepartments();

        Employee GetEmployee(int id);

        Department GetDepartment(int id);

        void CreateEmployee(Employee employee);
    }
}
