using GestoriumAPI.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestoriumAPI.Infra.Context
{
	public class DataBaseContext(DbContextOptions<DataBaseContext> options) : DbContext(options)
	{
		public DbSet<Products>? Products { get; set; }
		public DbSet<ServiceOrder>? ServiceOrder { get; set; }
		public DbSet<Client>? Client { get; set; }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			base.OnModelCreating(modelBuilder);
		}
	}
}
