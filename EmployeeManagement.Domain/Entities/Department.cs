using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement.Domain.Entities
{
	public class Department
	{
		[Key]
		public int Id { get; set; }
		[Required, MaxLength(300)]
		public string Name { get; set; }
		public DateTime CreatedDate { get; set; }
		public DateTime UpdatedDate { get; set; }
		public DateTime DeletedDate { get; set; }
		public List<Employee> Employees { get; set; }
	}
}
