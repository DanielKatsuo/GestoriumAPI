using GestoriumAPI.Domain.Entities.Base;
using GestoriumAPI.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestoriumAPI.Domain.Entities.Financial
{
	public sealed class TotalizersFinancial : BaseEntity
	{
		public PeriodType Period { get; set; }
		public DateTime ReferenceDate { get; set; }
		public decimal TotalRevenue { get; set; }
		public decimal TotalExpenses { get; set; }
		public decimal TotalBalance { get; set; }
		public decimal InitialBalance { get; set; }
		public decimal CumulativeBalance { get; set; }
		public DateTime LastUpdate { get; set; }
	}
}
