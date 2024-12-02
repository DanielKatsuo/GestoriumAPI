using GestoriumAPI.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GestoriumAPI.Infra.Context;

namespace GestoriumAPI.Infra.Repositories
{
	public class UnitOfWork(DataBaseContext context) : IUnitOfWork
	{
		private readonly DataBaseContext _context = context;

		public async Task CommitAsync()
		{
			await _context.SaveChangesAsync();
		}

		public async Task RollbackAsync()
		{
			await _context.DisposeAsync();
		}
	}
}
