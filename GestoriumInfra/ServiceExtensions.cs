using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GestoriumAPI.Infra.Context;
using GestoriumAPI.Domain.Interfaces;
using GestoriumAPI.Infra.Repositories;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace GestoriumAPI.Infra;

	public static class ServiceExtensions
	{
		public static void ConfigureInfraApp(this IServiceCollection services, IConfiguration configuration)
		{
			var connectionString = configuration.GetConnectionString("SQLite");
			services.AddDbContext<DataBaseContext>(options => options.UseSqlite(connectionString));
			services.AddScoped<IServiceOrderRepository, ServiceOrderRepository>();
			services.AddTransient<IClientRepository, ClientRepository>();
			services.AddScoped<IUnitOfWork, UnitOfWork>();
		}
	}
