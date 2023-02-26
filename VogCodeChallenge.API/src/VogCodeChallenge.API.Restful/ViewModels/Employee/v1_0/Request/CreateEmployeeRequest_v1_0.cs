using System.ComponentModel.DataAnnotations;

namespace VogCodeChallenge.API.Restful.ViewModels.Employee.v1_0.Request
{
    public class CreateEmployeeRequest_v1_0
    {

        /// <summary>
        /// First Name of Employee
        /// </summary>
        [Required]
        public string FirstName { get; set; } = string.Empty;

        /// <summary>
        /// Last Name of Employee
        /// </summary>
        [Required]
        public string LastName { get; set; } = string.Empty;

        /// <summary>
        /// Job Title for Employee
        /// </summary>
        [Required]
        public string JobTitle { get; set; } = string.Empty;

        /// <summary>
        /// Mailing Address
        /// </summary>
        [Required]
        public string Address { get; set; } = string.Empty;

        /// <summary>
        /// Department that employee is assigned to
        /// </summary>
        [Required]
        public Guid DepartmentId { get; set; }
    }
}
