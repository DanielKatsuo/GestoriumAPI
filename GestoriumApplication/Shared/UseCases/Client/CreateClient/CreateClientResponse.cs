using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestoriumAPI.Application.Shared.UseCases.Client.CreateClient
{
	public sealed record UpdateClientResponse
	{
		public string Customer { get; init; } = string.Empty;
		public string CustomerPhone { get; init; } = string.Empty;
	}
}
