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

namespace GestoriumAPI.Infra
{
	public static class ServiceExtensions
	{
		public static void AddInfra(this IServiceCollection services, IConfiguration configuration)
		{
			services.AddDbContext<DataBaseContext>(options =>
				options.UseSqlite(configuration.GetConnectionString("SQLite")));
			services.AddScoped<IServiceOrderRepository, ServiceOrderRepository>();
			services.AddScoped<IUnitOfWork, UnitOfWork>();
		}
	}
}
