using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement.Application.Dto.Employee
{
	public class EmployeeCreateDto
	{
		[Required, MaxLength(150)]
		public string Name { get; set; }
		[Required, MaxLength(200), EmailAddress]
		public string Email { get; set; }
		[Required]
		public int DepartmentId { get; set; }
		[Required]
		public DateTime HireDate { get; set; }
		[Required, MaxLength(200)]
		public string Status { get; set; }
	}
}
