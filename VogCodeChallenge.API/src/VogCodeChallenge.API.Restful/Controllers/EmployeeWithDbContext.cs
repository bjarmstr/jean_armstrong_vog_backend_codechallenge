using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using VogCodeChallenge.API.Application.IServices;
using VogCodeChallenge.API.Domain.Entity;
using VogCodeChallenge.API.Infrastructure.Persistence;
using VogCodeChallenge.API.Restful.ViewModels.Employee.v1_0.Request;
using VogCodeChallenge.API.Restful.ViewModels.Employee.v1_0.Response;

namespace VogCodeChallenge.API.Restful.Controllers
{
    [ApiController]
    [Route("api/employees2")]
    [ApiVersion("1.0")]
    public class Employee2Controller : ControllerBase
    {
        private readonly IEmployeeService _employeeService;
        private readonly ApplicationDbContext _dbContext;

        public Employee2Controller(IEmployeeService employeeService, ApplicationDbContext dbContext)
        {
            _employeeService = employeeService;
            _dbContext = dbContext;
        }

        /// <summary>
        /// List of all Employees
        /// </summary>
        /// <returns></returns>
        [HttpGet("")]
        [MapToApiVersion("1.0")]
        public ActionResult<List<EmployeeResponse_v1_0>> GetEmployees()
        {

            var results = _dbContext.Employees.Select(emp => new Application.DTOs.Employees.EmployeeDTO(emp)).ToList();

            var response = results.Select(emp => new EmployeeResponse_v1_0(emp)).ToList();
            return response;
        }



        /// <summary>
        /// Add an Employee
        /// </summary>
        /// <returns></returns>
        [HttpPost("")]
        [MapToApiVersion("1.0")]
        public async Task<ActionResult<EmployeeResponse_v1_0>> CreateEmployee([FromBody] CreateEmployeeRequest_v1_0 data)
        {
            
                var employee = new Employee
                {
                    Id = Guid.NewGuid(),
                    FirstName = data.FirstName,
                    LastName = data.LastName,
                    JobTitle = data.JobTitle,
                    Address = data.Address,
                    DepartmentId = data.DepartmentId
                };

                await _dbContext.Employees.AddAsync(employee);
                await _dbContext.SaveChangesAsync().ConfigureAwait(false);

                var response = new EmployeeResponse_v1_0
                {
                    Id = employee.Id,
                    FirstName = employee.FirstName,
                    LastName = employee.LastName,
                    JobTitle = employee.JobTitle,
                    Address = employee.Address,
                    DepartmentId = employee.DepartmentId,
                };
        

            return Ok(response);
        }


        /// <summary>
        /// Seed Data
        /// </summary>
        [HttpPut("department/{departmentId}")]
        [MapToApiVersion("1.0")]
        public async Task<ActionResult<string>> SeedData()
        {
            var department = new Department
            {
                Id = new Guid("8f02afbd-da06-4271-b239-f716780f59c6"),
                Name = "Engineering",
                Address = "Suite 123"
            };
            await _dbContext.Departments.AddAsync(department);

            var department2 = new Department
            {
                Id = new Guid("dbbad7e3-13c9-45ce-9ab0-d3c39ba032d8"),
                Name = "Engineering",
                Address = "Suite 56"
            };
            await _dbContext.Departments.AddAsync(department);


            var employee = new Employee
            {
                Id = Guid.NewGuid(),
                FirstName = "Kelly",
                LastName = "Jones",
                JobTitle = "Engineer",
                Address = "123 street",
                DepartmentId = new Guid("8f02afbd-da06-4271-b239-f716780f59c6")
            };
            await _dbContext.Employees.AddAsync(employee);
            
            var employee2 = new Employee
            {
                Id = Guid.NewGuid(),
                FirstName = "Suzy",
                LastName = "Allen",
                JobTitle = "Engineer",
                Address = "123 street",
                DepartmentId = new Guid("8f02afbd-da06-4271-b239-f716780f59c6")
            }; 
            await _dbContext.Employees.AddAsync(employee2);

            var employee3 = new Employee
            {
                Id = Guid.NewGuid(),
                FirstName = "Ken",
                LastName = "Newster",
                JobTitle = "Software Developer",
                Address = "735 street",
                DepartmentId = new Guid("dbbad7e3-13c9-45ce-9ab0-d3c39ba032d8")
            };
            await _dbContext.Employees.AddAsync(employee3);
            await _dbContext.SaveChangesAsync().ConfigureAwait(false);

            return Ok("OK");
        }

    }
}