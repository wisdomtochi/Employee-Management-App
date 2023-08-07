using Microsoft.EntityFrameworkCore;

namespace EmploymentManagement.Models
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>().HasData(
                new Employee
                {
                    Id = 1,
                    Name = "Tom",
                    Email = "tom@gmail.com",
                    Department = Dept.IT
                },
                new Employee
                {
                    Id = 2,
                    Name = "John",
                    Email = "john@gmail.com",
                    Department = Dept.HR
                }
             );
        }
    }
}
