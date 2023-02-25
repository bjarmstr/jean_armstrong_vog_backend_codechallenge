using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VogCodeChallenge.API.Application.IServices;
using VogCodeChallenge.API.Infrastructure.Services;

namespace VogCodeChallenge.API.Infrastructure
{
    public static class ServiceInitializer
    {

        public static IServiceCollection RegisterApplicationServices(this IServiceCollection services)
        {
            return services
                .AddScoped<IEmployeeService, EmployeeService>();
        }

    }
}
