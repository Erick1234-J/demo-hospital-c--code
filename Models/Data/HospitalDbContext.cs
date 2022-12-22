using Microsoft.EntityFrameworkCore;

namespace HospitalSystem.Models.Data
{
    public class HospitalDbContext: DbContext
    {
        public HospitalDbContext(DbContextOptions<HospitalDbContext> options) : base(options)
        {

        }

        public DbSet<Prescription> Prescriptions { get; set; }

        public DbSet<Department> Departments { get; set; }

        public DbSet<Employee> Employees { get; set; }

    }
}
