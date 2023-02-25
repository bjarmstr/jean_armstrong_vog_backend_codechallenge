using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using VogCodeChallenge.API.Application.IServices;
using VogCodeChallenge.API.Domain.Entity;

namespace VogCodeChallenge.API.Restful.Controllers
{
    [ApiController]
    [Route("api/employees")]
    [ApiVersion("1.0")]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeService _employeeService;

        public EmployeeController(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        [HttpGet("")]
        [MapToApiVersion("1.0")]
        public IEnumerable<Employee> GetEmployees()
        {
           
                var myvar = _employeeService.GetAll();
         
            return myvar;
        }


        [HttpGet("/department/{departmentId}")]
        [MapToApiVersion("2.0")]
        public IList<Employee> ListEmployees()
        {
            var myvar = _employeeService.ListAll();
            return myvar;
        }
    }
}
