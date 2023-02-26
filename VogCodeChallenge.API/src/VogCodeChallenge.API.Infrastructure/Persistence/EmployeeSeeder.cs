using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VogCodeChallenge.API.Domain.Entity;
using static System.Formats.Asn1.AsnWriter;

namespace VogCodeChallenge.API.Infrastructure.Persistence
{
    public class EmployeeSeeder
    {
        public async static Task SeedEmployee(ApplicationDbContext context)
        {
            context.Database.EnsureCreated();
            if (context.Employees.Any())
            {
                return;
            }
            var employeeSeed = context.Employees.Add(new Employee
            {
                Id = Guid.NewGuid(),
                FirstName = "Jay",
                LastName = "Armstrong",
                Address = "123 Corning St",
                JobTitle = "Software dev",
                DepartmentId = new Guid("8f02afbd-da06-4271-b239-f716780f59c6")
            });

            context.Employees.Add(new Employee
            {
                Id = Guid.NewGuid(),
                FirstName = "Dax",
                LastName = "Jones",
                Address = "123 Corning St",
                JobTitle = "Sales manager",
                DepartmentId = new Guid("dbbad7e3-13c9-45ce-9ab0-d3c39ba032d8")
            });

            context.Employees.Add(new Employee
            {
                  Id = Guid.NewGuid(),
                  FirstName = "Jay",
                  LastName = "Rock",
                  Address = "123 Downing St",
                  JobTitle = "Sales manager",
                  DepartmentId = new Guid("dbbad7e3-13c9-45ce-9ab0-d3c39ba032d8")
              });
            await context.SaveChangesAsync();
        }
    }
}
