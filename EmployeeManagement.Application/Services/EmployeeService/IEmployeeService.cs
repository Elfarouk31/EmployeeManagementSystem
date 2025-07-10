using EmployeeManagement.Application.Dto.Employee;
using EmployeeManagement.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement.Application.Services.EmployeeService
{
	public interface IEmployeeService
	{
		Task<EmployeeDto> GetByIdAsync(int id);
		Task<List<EmployeeDto>> GetAllAsync();
		Task<EmployeeDto> AddAsync(EmployeeCreateDto employeeCreateDto);
		Task<EmployeeDto> UpdateAsync(EmployeeDto employeeDto);
		Task<string> DeleteAsync(int Id);
		Task<EmployeeDto> GetByNameAsync(string name);
		Task<List<EmployeeDto>> GetByDepartmentAsync(string name);
		Task<List<EmployeeDto>> GetByStatusAsync(string status);
		Task<List<EmployeeDto>> GetByHiringDateRangeAsync(DateTime startDate, DateTime endDate);
		Task<List<EmployeeDto>> GetAllSortingByNameAsync(string type);
		Task<List<EmployeeDto>> GetAllSortingHiringDateByAsync(string type);
		Task<List<Employee>> GetAllEmployeeLogsAsync();
	}
}
