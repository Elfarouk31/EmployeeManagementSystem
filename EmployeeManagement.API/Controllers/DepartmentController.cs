using DepartmentManagement.Application.Services.DepartmentServices;
using EmployeeManagement.Application.Dto.Department;
using EmployeeManagement.Application.Dto.Employee;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeManagement.API.Controllers
{
	public class DepartmentController : Controller
	{
		private readonly IDepartmentService _departmentService;

		public DepartmentController(IDepartmentService departmentService)
		{
			_departmentService = departmentService;
		}

		[HttpGet("GetAllDepartment")]
		public async Task<ActionResult<List<DepartmentDto>>> GetDepartment()
		{
			var result = await _departmentService.GetAllAsync();
			return Ok(result);
		}

		[HttpGet("GetDepartmentById")]
		public async Task<ActionResult<DepartmentDto>> GetDepartmentById([FromQuery] int id)
		{
			var result = await _departmentService.GetByIdAsync(id);

			return Ok(result);
		}


		[HttpPost("CreateDepartment")]
		public async Task<ActionResult<DepartmentDto>> AddDepartment([FromBody] DepartmentCreateDto DepartmentCreateDto)
		{
			var result = await _departmentService.AddAsync(DepartmentCreateDto);
			return Ok(result);
		}


		[HttpPatch("UpdateDepartment")]
		public async Task<ActionResult> EditDepartment(DepartmentDto DepartmentDto)
		{
			 await _departmentService.UpdateAsync(DepartmentDto);
			return Ok();
		}

		[HttpDelete("DeleteDepartment")]
		public async Task<ActionResult<string>> DeleteDepartment([FromQuery] int id)
		{
			var result = await _departmentService.DeleteAsync(id);
			return Ok(result);
		}

	}
}
