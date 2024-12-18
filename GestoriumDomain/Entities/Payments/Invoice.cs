using GestoriumAPI.Domain.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestoriumAPI.Domain.Entities.Payments
{
	public class Invoice : BaseEntity
	{
		public string? InvoiceNumber { get; set; } 
		public DateTime IssueDate { get; set; } 
		public DateTime DueDate { get; set; } 
		public decimal Amount { get; set; } 
		public string? Status { get; set; } 
		public string? PaymentMethod { get; set; }
	}
}
