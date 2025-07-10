using AutoMapper;
using EmployeeManagement.Application.Dto;
using EmployeeManagement.Application.Dto.Employee;
using EmployeeManagement.Application.Persistence.Contract;
using EmployeeManagement.Application.Services.EmployeeService;
using EmployeeManagement.Domain.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeManagement.API.Controllers
{
	[ApiController]
	[Route("api/[controller]")]
	public class EmployeeController : ControllerBase
	{
		private readonly IEmployeeService _employeeService;

		public EmployeeController(IEmployeeService employeeService)
		{
			_employeeService = employeeService;
		}


		[HttpGet("GetAllEmployeesLogs")]
		public async Task<ActionResult<List<EmployeeDto>>> GetAllEmployeesLogs()
		{
			var result =  await _employeeService.GetAllEmployeeLogsAsync();
			return Ok(result);
		}

		[HttpGet("GetAllEmployees")]
		public async Task<ActionResult<List<EmployeeDto>>> GetEmployee()
		{
			var result =  await _employeeService.GetAllAsync();
			return Ok(result);
		}

		[HttpGet("GetEmployeeById")]
		public async Task<ActionResult<EmployeeDto>> GetEmployeeById([FromQuery] int id)
		{
			var result = await _employeeService.GetByIdAsync(id);

			return Ok(result);
		}

		[HttpGet("GetEmployeeByName")]
		public async Task<ActionResult<EmployeeDto>> GetEmployeeByName([FromQuery] string name)
		{
			var result = await _employeeService.GetByNameAsync(name);

			return Ok(result);
		}

		[HttpPost("CreateEmployee")]
		public async Task<ActionResult<EmployeeDto>> AddEmployee([FromBody] EmployeeCreateDto employeeCreateDto)
		{
			var result = await _employeeService.AddAsync(employeeCreateDto);
			return Ok(result);
		}

		[HttpGet("GetByDepartment")]
		public async Task<ActionResult<List<EmployeeDto>>> GetByDepartmentAsync([FromQuery] string departmentName)
		{
			var result = await _employeeService.GetByDepartmentAsync(departmentName);
			return Ok(result);
		}

		[HttpGet("GetByStatus'active/suspended'")]
		public async Task<ActionResult<List<EmployeeDto>>> GetByStatusAsync([FromQuery] string status)
		{
			var result = await _employeeService.GetByStatusAsync(status);
			return Ok(result);
		}

		[HttpGet("GetByHiringDateRange")]
		public async Task<ActionResult<List<EmployeeDto>>> GetByHiringDateRangeAsync([FromQuery] DateTime start, DateTime end)
		{
			var result = await _employeeService.GetByHiringDateRangeAsync(start, end);
			return Ok(result);
		}

		[HttpGet("GetAllSortingByNameDescOrASC")]
		public async Task<ActionResult<List<EmployeeDto>>> GetAllSortingByNameAsync([FromQuery] string type)
		{
			var result = await _employeeService.GetAllSortingByNameAsync(type);
			return Ok(result);
		}

		[HttpGet("GetAllSortingByHiringDateDescOrASC")]
		public async Task<ActionResult<List<EmployeeDto>>> GetAllSortingHiringDateByAsync([FromQuery] string type)
		{
			var result = await _employeeService.GetAllSortingHiringDateByAsync(type);
			return Ok(result);
		}

		[HttpPatch("UpdateEmployee")]
		public async Task<ActionResult<EmployeeDto>> EditEmployee(EmployeeDto employeeDto)
		{
			var result = await _employeeService.UpdateAsync(employeeDto);
			return Ok(result);
		}

		[HttpDelete("DeleteEmployee")]
		public async Task<ActionResult<string>> DeleteEmployee([FromQuery] int id)
		{
			var result = await _employeeService.DeleteAsync(id);
			return Ok(result);
		}
	}
}
