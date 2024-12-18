using GestoriumAPI.Domain.Entities.Base;
using GestoriumAPI.Domain.Interfaces;
using GestoriumAPI.Infra.Context;
using Microsoft.EntityFrameworkCore;

namespace GestoriumAPI.Infra.Repositories
{
	public class BaseRepository<T> : IBaseRepository<T> where T : BaseEntity
	{
		private readonly DataBaseContext _context;
		private readonly DbSet<T> _dbSet;

		public BaseRepository(DataBaseContext context)
		{
			_context = context;
			_dbSet = _context.Set<T>();
		}

		public async Task<IEnumerable<T>> GetAllAsync()
		{
			return await _dbSet.ToListAsync();
		}

		public async Task<T> GetByIdAsync(Guid id)
		{
			var result = await _dbSet.FindAsync(id);
			return result ?? Activator.CreateInstance<T>();
		}

		public async Task AddAsync(T entity)
		{
			await _dbSet.AddAsync(entity);
			await _context.SaveChangesAsync();
		}

		public async Task UpdateAsync(T entity)
		{
			_dbSet.Update(entity);
			await _context.SaveChangesAsync();
		}

		public async Task DeleteAsync(Guid id)
		{
			var entity = await _dbSet.FindAsync(id);
			if (entity != null)
			{
				_dbSet.Remove(entity);
				await _context.SaveChangesAsync();
			}
		}
	}
}
