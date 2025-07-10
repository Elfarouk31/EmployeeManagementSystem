using EmployeeManagement.Domain.Entities;
using AutoMapper;
using EmployeeManagement.Application.Dto.Employee;
using EmployeeManagement.Application.Persistence.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml.Schema;

namespace EmployeeManagement.Application.Services.EmployeeService
{
	public class EmployeeService : IEmployeeService
	{
		private readonly IEmployeeRepository _employeeRepository;
		private readonly IMapper _mapper;

		public EmployeeService(IEmployeeRepository employeeRepository, IMapper mapper)
		{
			_employeeRepository = employeeRepository;
			_mapper = mapper;
		}

		//C:\Program Files (x86)\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\Backup\
		public async Task<EmployeeDto> AddAsync(EmployeeCreateDto employeeCreateDto)
		{
			Employee employee = new Employee();
			EmployeeDto employeeDto = new EmployeeDto();

			if(employeeCreateDto == null)
				return employeeDto;

			employee = _mapper.Map<Employee>(employeeCreateDto);
			employee.CreatedDate = DateTime.Now;

			employeeDto = _mapper.Map<EmployeeDto>( await _employeeRepository.AddAsync(employee));

			return employeeDto;
		}

		public async Task<string> DeleteAsync(int id)
		{
			if (id <= 0)
				return "invalid data";

			Employee employee = new Employee();

			employee = await _employeeRepository.GetByIdAsync(id);

			if (employee == null)
				return "Employee Not Found";
			else
			{
				employee.DeletedDate = DateTime.Now;
				await _employeeRepository.UpdateAsync(employee);
				return $"{employee.Name} Deleted Successful";
			}
		}

		public async Task<List<EmployeeDto>> GetAllAsync()
		{
			List<EmployeeDto> result = new List<EmployeeDto>();
			List<Employee> employees = new List<Employee>();

			employees = await _employeeRepository.GetAllAsync();
			result = _mapper.Map<List<EmployeeDto>>(employees.Where(o => o.DeletedDate == null));

			return result;
		}

		public async Task<List<Employee>> GetAllEmployeeLogsAsync()
		{
			return await _employeeRepository.GetAllAsync();
		}

		public async Task<List<EmployeeDto>> GetAllSortingByNameAsync(string type)
		{
			List<EmployeeDto> result = new List<EmployeeDto>();

			if (type == null)
				return result;

			result = _mapper.Map<List<EmployeeDto>>(await _employeeRepository.GetAllSortingByNameAsync(type));

			return result;
		}

		public async Task<List<EmployeeDto>> GetAllSortingHiringDateByAsync(string type)
		{
			List<EmployeeDto> result = new List<EmployeeDto>();

			if (type == null)
				return result;

			result = _mapper.Map<List<EmployeeDto>>(await _employeeRepository.GetAllSortingHiringDateByAsync(type));

			return result;
		}

		public async Task<List<EmployeeDto>> GetByDepartmentAsync(string name)
		{
			List<EmployeeDto> result = new List<EmployeeDto>();

			if (name == null)
				return result;

			result = _mapper.Map<List<EmployeeDto>>(await _employeeRepository.GetByDepartmentAsync(name));

			return result;
		}

		public async Task<List<EmployeeDto>> GetByHiringDateRangeAsync(DateTime startDate, DateTime endDate)
		{
			List<EmployeeDto> result = new List<EmployeeDto>();

			if (startDate == null || endDate == null)
				return result;

			result = _mapper.Map<List<EmployeeDto>>(await _employeeRepository.GetByHiringDateRangeAsync(startDate, endDate));

			return result;
		}

		public async Task<EmployeeDto> GetByIdAsync(int id)
		{
			EmployeeDto result = new EmployeeDto();

			if (id == null)
				return result;

			result = _mapper.Map<EmployeeDto>(await _employeeRepository.GetByIdAsync(id));
			return result;

		}

		public async Task<EmployeeDto> GetByNameAsync(string name)
		{
			EmployeeDto result = new EmployeeDto();

			if (name == null)
				return result;

			result = _mapper.Map<EmployeeDto>(await _employeeRepository.GetByNameAsync(name));

			return result;
		}

		public async Task<List<EmployeeDto>> GetByStatusAsync(string status)
		{
			List<EmployeeDto> result = new List<EmployeeDto>();

			if (status == null)
				return result;

			result = _mapper.Map<List<EmployeeDto>>(await _employeeRepository.GetByStatusAsync(status));

			return result;
		}

		public async Task<EmployeeDto> UpdateAsync(EmployeeDto employeeDto)
		{
			Employee employee = new Employee();

			if (employeeDto == null)
				return employeeDto;

			employee = _mapper.Map<Employee>(employeeDto);

			employee.UpdatedDate = DateTime.Now;

			await _employeeRepository.UpdateAsync(employee);

			employeeDto = _mapper.Map<EmployeeDto>(await _employeeRepository.GetByNameAsync(employee.Name));

			return employeeDto;

		}
	}
}
