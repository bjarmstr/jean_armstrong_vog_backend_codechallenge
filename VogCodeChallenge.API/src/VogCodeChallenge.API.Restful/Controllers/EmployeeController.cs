﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Localization;
using VogCodeChallenge.API.Application.IServices;
using VogCodeChallenge.API.Domain.Entity;
using VogCodeChallenge.API.Restful.ViewModels.Employee.v1_0.Response;
using VogCodeChallenge.Shared;


namespace VogCodeChallenge.API.Restful.Controllers
{
    [ApiController]
    [Route("api/employees")]
    [ApiVersion("1.0")]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeService _employeeService;
        //IStringLocalizer<ResourceShared> _localizer;

        public EmployeeController(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
  
        }

        /// <summary>
        /// List of all Employees
        /// </summary>
        /// <returns></returns>
        [HttpGet("")]
        [MapToApiVersion("1.0")]
        public ActionResult<List<EmployeeResponse_v1_0>> GetEmployees()
        {
           
            var results = _employeeService.GetAllEmployees();
            var response = results.Select(emp => new EmployeeResponse_v1_0(emp)).ToList();

            return response;
        }

        /// <summary>
        /// List of all Employees in a Department
        /// </summary>
        /// <returns></returns>
        [HttpGet("department/{departmentId}")]
        [MapToApiVersion("1.0")]
        public ActionResult<List<EmployeeResponse_v1_0>> GetEmployeesInDepartment([FromRoute] Guid departmentId)
        {

            var results = _employeeService.GetEmployeesInDepartment(departmentId);
            var response = results.Select(emp => new EmployeeResponse_v1_0(emp)).ToList();

            return response;
        }


    }
}
