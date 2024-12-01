using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestoriumAPI.Domain.Entities
{
	public sealed class Products : BaseEntity
	{
		public required string Name { get; set; }
		public required string Description { get; set; }
		public decimal Price { get; set; }
		public int Stock { get; set; }
		public string? Image { get; set; }
	}
}
