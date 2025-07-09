using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeManagement.API.Controllers
{
	[ApiController]
	[Route("api/[controller]")]
	public class EmployeeController : ControllerBase
	{
		[HttpGet("GetAllEmployees")]
		public IActionResult GetEmployee(string Employee)
		{
			return Ok("Employee");
		}

		[HttpPost("AddEmployee")]
		public IActionResult AddEmployee(string Employee)
		{
			return Ok("Employee");
		}

		[HttpPatch("EditEmployee")]
		public IActionResult EditEmployee(string Employee)
		{
			return Ok("Employee");
		}

		[HttpDelete("DeleteEmployee")]
		public IActionResult DeleteEmployee(string Employee)
		{
			return Ok("Employee");
		}
	}
}
