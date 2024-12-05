using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestoriumAPI.Application.UseCases.CreateClient
{
	public sealed record CreateClientResponse
	{
		public Guid Id { get; init; }
		public string Customer { get; init; } = string.Empty;
		public string CustomerPhone { get; init; } = string.Empty;
	}
}
