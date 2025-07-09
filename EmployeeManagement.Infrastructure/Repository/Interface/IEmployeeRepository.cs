using EmployeeManagement.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement.Infrastructure.Repository.Interface
{
	interface IEmployeeRepository : IGenericRepository<Employee>
	{
		Task<Employee> GetByNameAsync(string name);
		Task<List<Employee>> GetByDepartmentAsync(string name);
		Task<List<Employee>> GetByStatusAsync(string status);
		Task<List<Employee>> GetByHiringDateRangeAsync(DateTime startDate, DateTime endDate);
		Task<List<Employee>> GetAllSortingByNameAsync(string type);
		Task<List<Employee>> GetAllSortingHiringDateByAsync(string type);
	}
}
