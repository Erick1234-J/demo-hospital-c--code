namespace HospitalSystem.Models.Data
{
    public interface IDepartmentRepository
    {
        IEnumerable<Department> GetDepartments();

        Department GetDepartmentById(int id);

        void CreateDepartment(Department department);


    }
}
