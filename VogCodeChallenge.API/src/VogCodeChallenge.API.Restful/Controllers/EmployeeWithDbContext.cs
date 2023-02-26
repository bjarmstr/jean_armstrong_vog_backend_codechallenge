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
        public async Task<ActionResult<string>> CreateEmployee([FromBody] CreateEmployeeRequest_v1_0 data)
        {

            var employee = new Employee
            {
                FirstName = data.FirstName,
                LastName = data.LastName,
                JobTitle = data.JobTitle,
                Address = data.Address,
                DepartmentId = data.DepartmentId
            };

            await _dbContext.Employees.AddAsync(employee);
            await _dbContext.SaveChangesAsync().ConfigureAwait(false);



            return "k";
        }

    }
}
