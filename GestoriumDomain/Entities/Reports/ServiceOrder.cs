
using GestoriumAPI.Domain.Entities.Products;

namespace GestoriumAPI.Domain.Entities.Reports
{
	public sealed class ServiceOrder : BaseEntity
	{
		public required string Customer { get; set; }
		public required string CustomerContact { get; set; }
		public DateTime OpenDate { get; set; }
		public DateTime? CompletionDate { get; set; }
		public string? ServiceDescription { get; set; }
		public string? Status { get; set; }
		public decimal? EstimatedValue { get; set; }
		public decimal? FinalValue { get; set; }
		public string? AssignedTo { get; set; }
		public List<Product> Products { get; set; } = [];


	}
}
