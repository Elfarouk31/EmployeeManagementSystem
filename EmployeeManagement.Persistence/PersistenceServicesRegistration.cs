using EmployeeManagement.Application.Persistence.Contract;
using EmployeeManagement.Persistence.Repository.Implementation;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace EmployeeManagement.Persistence
{
	public static class PersistenceServicesRegistration
	{
		public static IServiceCollection ConfigurationPersistenceServices(this IServiceCollection services, IConfiguration configuration)
		{
			services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
			services.AddScoped<IEmployeeRepository, EmployeeRepository>();
			services.AddScoped<IDepartmentRepository, DepartmentRepository>();

			return services;
		}
	}
}
