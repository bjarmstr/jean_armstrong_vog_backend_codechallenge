using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VogCodeChallenge.API.Application.DTOs.Employees
{
    public class EmployeeDTO
    {
        public EmployeeDTO() { }

        public EmployeeDTO(Domain.Entity.Employee src)
        {
            Id = src.Id;
            FirstName = src.FirstName;
            LastName = src.LastName;
            JobTitle = src.JobTitle;
            Address = src.Address;
            DepartmentId = src.DepartmentId;
        }


        /// <summary>
        /// Employee Unique Identifier
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// First Name of Employee
        /// </summary>
        public string FirstName { get; set; } = string.Empty;

        /// <summary>
        /// Last Name of Employee
        /// </summary>
        public string LastName { get; set; } = string.Empty;

        /// <summary>
        /// Job Title for Employee
        /// </summary>
        public string JobTitle { get; set; } = string.Empty;

        /// <summary>
        /// Mailing Address
        /// </summary>
        public string Address { get; set; } = string.Empty;

        /// <summary>
        /// Department that employee is assigned to
        /// </summary>
        public Guid DepartmentId { get; set; }

    }
}
