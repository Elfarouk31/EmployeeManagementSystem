using EmployeeManagement.Application.Dto.Department;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DepartmentManagement.Application.Services.DepartmentServices
{
	public interface IDepartmentService
	{
		Task<DepartmentDto> GetByIdAsync(int id);
		Task<List<DepartmentDto>> GetAllAsync();
		Task<DepartmentDto> AddAsync(DepartmentCreateDto DepartmentCreateDto);
		Task UpdateAsync(DepartmentDto DepartmentDto);
		Task<string> DeleteAsync(int Id);
	}
}
