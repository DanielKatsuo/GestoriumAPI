using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestoriumAPI.Application.UseCases.Client.CreateClient
{
	public sealed record CreateClientRequest(string Customer, string CustomerPhone) : IRequest<CreateClientResponse>
	{

	}
}
