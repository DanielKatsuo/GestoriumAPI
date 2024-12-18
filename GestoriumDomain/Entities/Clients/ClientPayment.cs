using GestoriumAPI.Domain.Entities.Base;
using GestoriumAPI.Domain.Enums;

namespace GestoriumAPI.Domain.Entities.Clients;
public class ClientPayment : BaseEntity
{
	public Guid CustomerId { get; set; }
	public decimal Amount { get; set; }
	public DateTime PaymentDate { get; set; }
	public PaymentMethod Method { get; set; }
	public string? Description { get; set; }
}
