using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VogCodeChallenge.API.Domain.Entity
{
    /// <summary>
    /// Base Entity that other Entities can Inherit from
    /// </summary>
    /// <typeparam name="TPrimaryKey"></typeparam>
    public abstract class BaseEntity<TPrimaryKey>
    {
        /// <summary>
        /// PrimaryKey
        /// </summary>
        public TPrimaryKey Id { get; set; }
    }
}
