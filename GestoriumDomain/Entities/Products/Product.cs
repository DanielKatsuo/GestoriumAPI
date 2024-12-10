using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestoriumAPI.Domain.Entities.Products
{
	public sealed class Product : BaseEntity
	{
		public required string Name { get; set; }
		public required string Code { get; set; }
		public int StockQuantity { get; set; }
		public int MinQuantity { get; set; }
		public required UnitOfMeasure UnitOfMeasure { get; set; }
		public decimal UnitPrice { get; set; }

	}

	public enum UnitOfMeasure
	{
		Unidade,
		Kilo,
		Litro,
		Metro,
		Caixa,
		Pacote,
		Outro
	}
}
