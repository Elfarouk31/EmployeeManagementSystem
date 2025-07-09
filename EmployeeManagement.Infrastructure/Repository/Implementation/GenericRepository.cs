using EmployeeManagement.Infrastructure.DbContextModel;
using EmployeeManagement.Infrastructure.Repository.Interface;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement.Infrastructure.Repository.Implementation
{
	public class GenericRepository<T> : IGenericRepository<T> where T : class
	{
		private readonly AppDbContext _appDbContext;

		public GenericRepository(AppDbContext appDbContext)
		{
			_appDbContext = appDbContext;
		}
		public async Task<T> AddAsync(T entity)
		{
			await _appDbContext.AddAsync(entity);
			await _appDbContext.SaveChangesAsync();
			return entity;
		}

		public async Task DeleteAsync(T entity)
		{
			_appDbContext.Set<T>().Remove(entity);
			await _appDbContext.SaveChangesAsync();
		}

		public async Task<List<T>> GetAllAsync()
		{
			List<T> result = await _appDbContext.Set<T>().ToListAsync();
			return result;
		}

		public async Task<T> GetByIdAsync(int id)
		{
			T result = await _appDbContext.Set<T>().FindAsync(id);
			return result;
		}

		public async Task UpdateAsync(T entity)
		{
			_appDbContext.Update(entity);
			await _appDbContext.SaveChangesAsync();
		}
	}
}
