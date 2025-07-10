using DepartmentManagement.Application.Services.DepartmentServices;
using EmployeeManagement.Application.Services.DepartmentServices;
using EmployeeManagement.Application.Services.EmployeeService;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement.Application
{
	public static class ApplicationServicesRegistration
	{
		public static IServiceCollection ConfigurationApplicationServices(this IServiceCollection services)
		{
			services.AddAutoMapper(Assembly.GetExecutingAssembly());

			services.AddScoped<IEmployeeService, EmployeeService>();
			services.AddScoped<IDepartmentService, DepartmentServices>();

			return services;
		}
	}
}
