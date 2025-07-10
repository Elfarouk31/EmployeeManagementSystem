using AutoMapper;
using EmployeeManagement.Application.Dto.Department;
using EmployeeManagement.Application.Dto.Employee;
using EmployeeManagement.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement.Application.Profiles.MappingProfile
{
	public class MappingProfile : Profile
	{
		public MappingProfile()
		{
			// Mapping Employee
			CreateMap<Employee, EmployeeDto>().ReverseMap();
			CreateMap<Employee, EmployeeCreateDto>().ReverseMap();

			// Mapping Department
			CreateMap<Department, DepartmentDto>().ReverseMap();
			CreateMap<Department, DepartmentCreateDto>().ReverseMap();
		}
	}
}
