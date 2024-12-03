using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestoriumAPI.Domain.Entities
{
	public sealed class Products : BaseEntity
	{
		public required string Name { get; init; }
		public required string Description { get; init; }
		public decimal Price { get; init; }
		public int Stock { get; init; }
		public string? Image { get; init; }
	}
}
