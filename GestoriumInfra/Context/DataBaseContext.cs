using GestoriumAPI.Domain.Entities.Clients;
using GestoriumAPI.Domain.Entities.Financial;
using GestoriumAPI.Domain.Entities.Payments;
using GestoriumAPI.Domain.Entities.Products;
using GestoriumAPI.Domain.Entities.Reports;
using GestoriumAPI.Domain.Entities.Stock;
using GestoriumAPI.Domain.Entities.Suppliers;
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
		public DbSet<ClientInfo>? ClientInfo { get; set; }
		public DbSet<ClientPayment>? ClientPayment { get; set; }
		public DbSet<StockMovement>? StockMovement { get; set; }
		public DbSet<Invoice>? Invoice { get; set; }
		public DbSet<ProvidedServices>? Report { get; set; }
		public DbSet<Suppliers>? Suppliers { get; set; }
		public DbSet<Purchases>? Purchases { get; set; }
		public DbSet<TotalizersFinancial>? TotalizersFinancial { get; set; }


		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			base.OnModelCreating(modelBuilder);
		}
	}
}
