using GestoriumAPI.Domain.Entities;

namespace GestoriumDomain.Entities
{
    public sealed class ServiceOrder : BaseEntity
    {
		public required string Customer { get; set; }
		public required string  CustomerContact { get; set; }
		public DateTime OpenDate { get; set; }
		public DateTime? CompletionDate { get; set; }
		public string? ServiceDescription { get; set; }
		public string? Status { get; set; }
		public decimal? EstimatedValue { get; set; }
		public decimal? FinalValue { get; set; }
		public string? AssignedTo { get; set; }
		public List<ServiceItem> Items { get; set; } = new List<ServiceItem>();
		public List<Products> Products { get; set; } = new List<Products>();

		public class ServiceItem
		{
			public int Id { get; set; }
			public string? Description { get; set; }
			public int Quantity { get; set; }
			public decimal UnitPrice { get; set; }
			public decimal Total => Quantity * UnitPrice;
		}

	}
}
