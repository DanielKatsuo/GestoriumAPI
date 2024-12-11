using GestoriumAPI.Domain.Entities.Clients;
using GestoriumAPI.Domain.Entities.Payments;
using GestoriumAPI.Domain.Entities.Products;
using GestoriumAPI.Domain.Entities.Reports;
using GestoriumAPI.Domain.Entities.Stock;
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
		public DbSet<Product>? Products { get; set; }
		public DbSet<ServiceOrder>? ServiceOrder { get; set; }
		public DbSet<ClientInfo>? Client { get; set; }
		public DbSet<StockMovement>? StockMovement { get; set; }
		public DbSet<Invoice>? Invoice { get; set; }
		public DbSet<ProvidedServices>? Report { get; set; }


		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			base.OnModelCreating(modelBuilder);
		}
	}
}
