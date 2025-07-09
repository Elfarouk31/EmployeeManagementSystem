using EmployeeManagement.Domain.Entities;
using EmployeeManagement.Infrastructure.DbContextModel;
using EmployeeManagement.Infrastructure.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement.Infrastructure.Repository.Implementation
{
	public class DepartmentRepository : GenericRepository<Department> , IDepartmentRepository
	{
		private readonly AppDbContext _appDbContext;

		public DepartmentRepository(AppDbContext appDbContext) : base(appDbContext)	
		{
			_appDbContext = appDbContext;
		}
	}
}
