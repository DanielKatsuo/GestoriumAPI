using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using GestoriumAPI.Domain.Entities.Reports;
using GestoriumAPI.Domain.Entities.Clients;

namespace GestoriumAPI.Application.Shared.UseCases.Client.UpdateClient
{
	public sealed class UpdateClientMapper : Profile
	{
		public UpdateClientMapper()
		{
			CreateMap<UpdateClientRequest, ClientInfo>();
			CreateMap<ClientInfo, UpdateClientResponse>();
		}
	}
}
