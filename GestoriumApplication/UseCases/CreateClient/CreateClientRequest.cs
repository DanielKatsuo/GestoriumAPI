using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestoriumAPI.Application.UseCases.CreateClient
{
	public sealed record CreateClientRequest (string Costumer, string CostumerPhone) : IRequest<CreateClientResponse>
	{

	}
}
