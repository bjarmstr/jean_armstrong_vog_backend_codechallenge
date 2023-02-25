using VogCodeChallenge.API.Application.IServices;
using VogCodeChallenge.API.Domain.Entity;

namespace VogCodeChallenge.API.Infrastructure
{
    public class EmployeeService : IEmployeeService
    {
        private static readonly List<Department> Departments = new List<Department>
        {
            new Department{ Id = new Guid("8f02afbd-da06-4271-b239-f716780f59c6"),
                            Name = "Engineering",
                            Address = "Suite 123"
            },
            new Department{ Id = new Guid("dbbad7e3-13c9-45ce-9ab0-d3c39ba032d8"),
                            Name = "Sales",
                            Address = "Suite 133"
            },
        };


        private static readonly List<Employee> employees = new List<Employee>
        {
            new Employee{ Id = Guid.NewGuid(),
                          FirstName = "Jay",
                          LastName = "Armstrong",
                          Address = "123 Corning St",
                          JobTitle = "Software dev",
                          DepartmentId = new Guid("8f02afbd-da06-4271-b239-f716780f59c6")
            },

            new Employee{ Id = Guid.NewGuid(),
                          FirstName = "Jay",
                          LastName = "Armstrong",
                          Address = "123 Corning St",
                          JobTitle = "Sales manager",
                          DepartmentId = new Guid("dbbad7e3-13c9-45ce-9ab0-d3c39ba032d8")
            },
        };


        public IEnumerable<Employee> GetAll()
        {

            return employees;
        }


    }
}