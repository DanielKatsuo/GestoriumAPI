using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestoriumAPI.Domain.Entities.Logger
{
	public class ErrorLog
	{
		public int Id { get; set; }
		public string? Message { get; set; }
		public string? StackTrace{ get; set; }
		public DateTime Date { get; set; }
		public string? Source { get; set; }
	}
}
