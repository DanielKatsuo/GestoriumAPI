using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GestoriumAPI.Domain.Entities;
using GestoriumAPI.Domain.Interfaces;
using GestoriumAPI.Infra.Context;

namespace GestoriumAPI.Infra.Repositories
{
	public class ServiceOrderRepository(DataBaseContext context) : BaseRepository<ServiceOrder>(context), IServiceOrderRepository
	{

	}
}
