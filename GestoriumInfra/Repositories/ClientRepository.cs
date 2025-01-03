﻿using GestoriumAPI.Domain.Entities.Clients;
using GestoriumAPI.Domain.Interfaces;
using GestoriumAPI.Infra.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestoriumAPI.Infra.Repositories
{
	public class ClientRepository(DataBaseContext context) : BaseRepository<ClientInfo>(context), IClientRepository
	{

	}
}
