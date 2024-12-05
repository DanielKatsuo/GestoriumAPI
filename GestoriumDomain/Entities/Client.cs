using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestoriumAPI.Domain.Entities
{
	public sealed class Client : BaseEntity
	{
		public required string Customer { get; set; }
		public string? CustomerPhone { get; set; }
		public string? CustomerAddress { get; set; }
		public string? CustomerCity { get; set; }
		public string? CustomerContactName { get; set; }
		public decimal? CustomerDebt { get; set; }
	}
}
