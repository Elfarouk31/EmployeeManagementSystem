using AutoMapper;
using DepartmentManagement.Application.Services.DepartmentServices;
using EmployeeManagement.Application.Dto.Department;
using EmployeeManagement.Application.Dto.Employee;
using EmployeeManagement.Application.Persistence.Contract;
using EmployeeManagement.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement.Application.Services.DepartmentServices
{
	public class DepartmentServices : IDepartmentService
	{
		private readonly IDepartmentRepository _departmentRepository;
		private readonly IMapper _mapper;

		public DepartmentServices(IDepartmentRepository departmentRepository, IMapper mapper)
		{
			_departmentRepository = departmentRepository;
			_mapper = mapper;
		}
		public async Task<DepartmentDto> AddAsync(DepartmentCreateDto DepartmentCreateDto)
		{
			Department department = new Department();
			DepartmentDto departmentDto = new DepartmentDto();

			if (DepartmentCreateDto == null)
				return departmentDto;

			department = _mapper.Map<Department>(DepartmentCreateDto);
			department.CreatedDate = DateTime.Now;

			departmentDto = _mapper.Map<DepartmentDto>( await _departmentRepository.AddAsync(department));

			return departmentDto;
		}

		public async Task<string> DeleteAsync(int id)
		{
			if (id <= 0)
				return "invalid data";

			Department department = new Department();

			department = await _departmentRepository.GetByIdAsync(id);

			if (department == null)
				return "department Not Found";
			else
			{
				department.DeletedDate = DateTime.Now;
				await _departmentRepository.UpdateAsync(department);
				return $"{department.Name} Deleted Successful";
			}
		}

		public async Task<List<DepartmentDto>> GetAllAsync()
		{
			List<DepartmentDto> result = new List<DepartmentDto>();
			List<Department> departments = new List<Department>();

			departments = await _departmentRepository.GetAllAsync();
			result = _mapper.Map<List<DepartmentDto>>(departments.Where(o => o.DeletedDate == null));

			return result;
		}

		public async Task<DepartmentDto> GetByIdAsync(int id)
		{
			DepartmentDto result = new DepartmentDto();

			if (id == null)
				return result;

			result = _mapper.Map<DepartmentDto>(await _departmentRepository.GetByIdAsync(id));
			return result;
		}

		public async Task UpdateAsync(DepartmentDto DepartmentDto)
		{
			Department department = new Department();

			if (DepartmentDto == null)
				return;

			department = _mapper.Map<Department>(DepartmentDto);

			department.UpdatedDate = DateTime.Now;

			await _departmentRepository.UpdateAsync(department);

			return;

		}
	}
}
