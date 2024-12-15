using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestoriumAPI.Domain.Entities.Clients
{
	public sealed class ClientInfo : BaseEntity
	{
		public required string Customer { get; set; }
		public string? CustomerPhone { get; set; }
		public string? CustomerAddress { get; set; }
		public string? CustomerCity { get; set; }
		public decimal? CustomerDebt { get; set; }
	}
}
