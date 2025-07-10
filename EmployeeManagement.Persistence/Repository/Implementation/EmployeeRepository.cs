using EmployeeManagement.Application.Persistence.Contract;
using EmployeeManagement.Domain.Entities;
using EmployeeManagement.Persistence.DbContextModel;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement.Persistence.Repository.Implementation
{
	public class EmployeeRepository : GenericRepository<Employee>, IEmployeeRepository
	{
		private readonly AppDbContext _appDbContext;

		public EmployeeRepository(AppDbContext appDbContext) : base(appDbContext) 
		{
			_appDbContext = appDbContext;
		}
		public async Task<List<Employee>> GetAllSortingByNameAsync(string type)
		{
			List<Employee> result = new List<Employee>();
			result = await GetAllAsync();

			if (type == "Desc")
				return result.Where(o => o.DeletedDate == null).OrderByDescending(o => o.Name).ToList();
			else
				return  result.Where(o => o.DeletedDate == null).OrderBy(o => o.Name).ToList();
		}

		public async Task<List<Employee>> GetAllSortingHiringDateByAsync(string type)
		{
			List<Employee> result = new List<Employee>();

			if (string.IsNullOrEmpty(type))
				return result;

			result = await GetAllAsync();

			if (type == "Desc")
				return result.Where(o => o.DeletedDate == null).OrderByDescending(o => o.HireDate).ToList();
			else
				return result.Where(o => o.DeletedDate == null).OrderBy(o => o.HireDate).ToList();
		}

		public async Task<List<Employee>> GetByDepartmentAsync(string name)
		{
			List<Employee> employees = new List<Employee>();
			Department department = new Department();
			
			if (!string.IsNullOrEmpty(name) && _appDbContext != null)
			{
				department = await _appDbContext.Departments
					.Where(o => o.Name == name && o.DeletedDate == null).FirstOrDefaultAsync();

				employees  = await _appDbContext.Employees
					.Where(o => o.DepartmentId == department.Id && o.DeletedDate == null).ToListAsync();
				return employees;
			}
			else
				return employees; 
		}

		public async Task<List<Employee>> GetByHiringDateRangeAsync(DateTime startDate, DateTime endDate)
		{
			List<Employee> employees = new List<Employee>();

			employees = await _appDbContext.Employees
				.Where(o => o.HireDate >= startDate && o.HireDate <= endDate && o.DeletedDate == null).ToListAsync();
			
			return employees;
		}

		public async Task<Employee> GetByNameAsync(string name)
		{
			Employee result = new Employee();
			if (string.IsNullOrEmpty(name))
				return result;
			else
				result = await _appDbContext.Employees.FirstOrDefaultAsync(o => o.Name == name && o.DeletedDate == null);
			return result;
		}

		public async Task<List<Employee>> GetByStatusAsync(string status)
		{
			List<Employee> employees = new List<Employee>();

			if (string.IsNullOrEmpty(status))
				return employees;

			employees = await _appDbContext.Employees
				.Where(o => o.Status == status && o.DeletedDate == null).ToListAsync();

			return employees;
		}
	}
}
