using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement.Domain.Entities
{
	public class Employee
	{
		[Key]
		public int Id { get; set; }
		[Required, MaxLength(150)]
		public string Name { get; set; }
		[Required, MaxLength(200), EmailAddress]
		public string Email { get; set; }
		public int? DepartmentId { get; set; }
		[Required]

		public DateTime HireDate { get; set; }
		[Required, MaxLength(200)]
		public string Status { get; set; }
		public DateTime CreatedDate { get; set; }
		public DateTime? UpdatedDate { get; set; }
		public DateTime? DeletedDate { get; set; }

		[ForeignKey("DepartmentId")]
		public Department Department { get; set; }

		public Employee()
		{
			
		}
	}
}
