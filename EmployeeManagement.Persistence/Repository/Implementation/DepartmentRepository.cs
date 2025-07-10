using EmployeeManagement.Application.Persistence.Contract;
using EmployeeManagement.Domain.Entities;
using EmployeeManagement.Persistence.DbContextModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement.Persistence.Repository.Implementation
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
