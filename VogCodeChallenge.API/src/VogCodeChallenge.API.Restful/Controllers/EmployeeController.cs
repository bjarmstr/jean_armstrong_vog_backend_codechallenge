using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using VogCodeChallenge.API.Application.IServices;
using VogCodeChallenge.API.Domain.Entity;
using VogCodeChallenge.API.Restful.ViewModels.Employee.v1_0.Response;

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
        public ActionResult<List<EmployeeResponse_v1_0>> GetEmployees()
        {
           
            var results = _employeeService.GetAll();
            var response = results.Select(emp => new EmployeeResponse_v1_0(emp)).ToList();

            return response;
        }


       
    }
}
