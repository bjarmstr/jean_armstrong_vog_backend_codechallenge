using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VogCodeChallenge.API.Domain.Entity
{
    /// <summary>
    /// Department Entity
    /// </summary>
    [Index(nameof(Address), IsUnique = true)]

    public class Department : BaseEntity<Guid>
    {
        /// <summary>
        /// Department Name
        /// </summary>
        [Required]
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// Each Department has a Unique Address
        /// </summary>
        [Required]
        public string Address { get; set; } = string.Empty;

        /// <summary>
        /// Employees in the Department
        /// </summary>
        public ICollection<Employee> Employees { get; set; } = new List<Employee>();
    }
}
