using VogCodeChallenge.API.Application.DTOs.Employees;
using VogCodeChallenge.API.Application.IServices;
using VogCodeChallenge.API.Domain.Entity;

namespace VogCodeChallenge.API.Infrastructure.Services
{
    public class EmployeeService : IEmployeeService
    {

        /// <summary>
        /// temporary test data for Departments
        /// </summary>
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

        /// <summary>
        /// temporary test data for Employees
        /// </summary>
        private static readonly List<Employee> Employees = new List<Employee>
        {
            new Employee{ Id = Guid.NewGuid(),
                          FirstName = "Jay",
                          LastName = "Armstrong",
                          Address = "123 Corning St",
                          JobTitle = "Software dev",
                          DepartmentId = new Guid("8f02afbd-da06-4271-b239-f716780f59c6")
            },

            new Employee{ Id = Guid.NewGuid(),
                          FirstName = "Dax",
                          LastName = "Jones",
                          Address = "123 Corning St",
                          JobTitle = "Sales manager",
                          DepartmentId = new Guid("dbbad7e3-13c9-45ce-9ab0-d3c39ba032d8")
            },

              new Employee{ Id = Guid.NewGuid(),
                          FirstName = "Jay",
                          LastName = "Rock",
                          Address = "123 Downing St",
                          JobTitle = "Sales manager",
                          DepartmentId = new Guid("40ade766-7b85-472d-a3ff-3964109d3d54")
            },
        };


        public IEnumerable<Employee> GetAll()
        {

            return Employees;
        }

        public IList<Employee> ListAll()
        {

            return Employees;
        }

        public IEnumerable<EmployeeDTO> GetAllEmployees()
        {

            var response = Employees.Select(emp => new EmployeeDTO(emp)).ToList();

            return response;
        }


    }
}