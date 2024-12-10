using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestoriumAPI.Domain.Entities.Reports
{
	public class ProvidedServices : BaseEntity
	{
		public required string Service { get; set; }
		public string? Veicle { get; set; } = "Genérico";
		public decimal? Value { get; set; }
		public string? Notes { get; set; }
	}
}
