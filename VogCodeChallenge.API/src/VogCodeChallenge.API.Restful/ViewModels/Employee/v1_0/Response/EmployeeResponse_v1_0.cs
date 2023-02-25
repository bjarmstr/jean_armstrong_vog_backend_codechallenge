using System.ComponentModel.DataAnnotations;

namespace VogCodeChallenge.API.Restful.ViewModels.Employee.v1_0.Response
{
    public class EmployeeResponse_v1_0
    {

        public EmployeeResponse_v1_0() { }

        public EmployeeResponse_v1_0(Domain.Entity.Employee src)
        {
            Id = src.Id;
            FirstName= src.FirstName;
            LastName= src.LastName;
            JobTitle= src.JobTitle;
            Address= src.Address;
            DepartmentId= src.DepartmentId;
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
