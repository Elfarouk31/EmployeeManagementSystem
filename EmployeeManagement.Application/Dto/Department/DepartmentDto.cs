using EmployeeManagement.Application.Dto.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement.Application.Dto.Department
{
	public class DepartmentDto : BaseDto
	{
		public string Name { get; set; }
	}
}
