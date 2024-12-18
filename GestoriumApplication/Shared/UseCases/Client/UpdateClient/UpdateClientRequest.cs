using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestoriumAPI.Application.Shared.UseCases.Client.UpdateClient
{
	public sealed record UpdateClientRequest(string Customer, string CustomerPhone) : IRequest<UpdateClientResponse>
	{

	}
}
