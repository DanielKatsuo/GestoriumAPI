using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GestoriumAPI.Domain.Entities.Products;
using GestoriumAPI.Domain.Enums;
namespace GestoriumAPI.Domain.Entities.Stock
{
	public sealed class StockMovement : BaseEntity
	{
		public int IdProduct { get; set; }
		public MovementType Type { get; set; }
		public StockStatus Situation { get; set; }
		public int Quantity { get; set; }
		public DateTime MovementDate { get; set; }
		public string? Notes { get; set; }
	}
}
