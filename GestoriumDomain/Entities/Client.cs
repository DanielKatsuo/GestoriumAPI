using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestoriumAPI.Domain.Entities
{
	public sealed class Client : BaseEntity
	{
		public string Customer { get; init; } = string.Empty;
		public string CustomerPhone { get; init; } = string.Empty;
		public string CustomerAddress { get; init; } = string.Empty;
		public string CustomerCity { get; init; } = string.Empty;
		public string CustomerContactName { get; init; } = string.Empty;
		public decimal CustomerDebt { get; init; }
	}
}
