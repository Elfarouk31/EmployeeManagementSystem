using EmployeeManagement.Infrastructure.Repository.Implementation;
using EmployeeManagement.Infrastructure.Repository.Interface;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement.Infrastructure
{
	public static class InfrastructureServicesRegistration
	{
		public static IServiceCollection ConfigurationInfrastructureServices(this IServiceCollection services, IConfiguration configuration)
		{
			services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
			services.AddScoped<IEmployeeRepository, EmployeeRepository>();
			services.AddScoped<IDepartmentRepository, DepartmentRepository>();

			return services;
		}
	}
}
