using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using GestoriumAPI.Domain.Entities;

namespace GestoriumAPI.Application.UseCases.Client.CreateClient
{
	public sealed class CreateClientMapper : Profile
	{
		public CreateClientMapper()
		{
			CreateMap<CreateClientRequest, Client>();
			CreateMap<Client, CreateClientResponse>();
		}
	}
}
