using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using GestoriumAPI.Domain.Entities.Reports;
using GestoriumAPI.Domain.Entities.Clients;

namespace GestoriumAPI.Application.UseCases.Client.CreateClient
{
	public sealed class CreateClientMapper : Profile
	{
		public CreateClientMapper()
		{
			CreateMap<CreateClientRequest, ClientInfo>();
			CreateMap<ClientInfo, CreateClientResponse>();
		}
	}
}
