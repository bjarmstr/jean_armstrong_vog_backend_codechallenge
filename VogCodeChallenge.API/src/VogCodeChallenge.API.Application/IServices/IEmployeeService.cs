﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VogCodeChallenge.API.Application.DTOs.Employees;
using VogCodeChallenge.API.Domain.Entity;

namespace VogCodeChallenge.API.Application.IServices
{
    public interface IEmployeeService
    {
        IEnumerable<Employee> GetAll();

        IList<Employee> ListAll();

        IEnumerable<EmployeeDTO> GetAllEmployees();

        IEnumerable<EmployeeDTO> GetEmployeesInDepartment(Guid departmentId);
    }
}
