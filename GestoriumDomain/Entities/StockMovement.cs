using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestoriumAPI.Domain.Entities
{
	public sealed class StockMovement
	{
		public int Id { get; set; }
		public required Products Product { get; set; } 
		public MovementType Type { get; set; }
		public StockStatus Situation { get; set; }
		public int Quantity { get; set; } 
		public DateTime MovementDate { get; set; } 
		public string? Notes { get; set; } 
	}

	public enum MovementType
	{
		Entrada,
		Saída
	}
	public enum StockStatus
	{
		Indisponível,
		Reduzido,
		Disponível,
	}
}
