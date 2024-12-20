using GestoriumAPI.Domain.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestoriumAPI.Domain.Entities.Suppliers
{
	public sealed class Suppliers : BaseEntity
	{
		public string? Supplier { get; set; }
		public string? SupplierPhone { get; set; }
	}
}
