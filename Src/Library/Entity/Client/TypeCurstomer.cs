using System.ComponentModel.DataAnnotations;

namespace Entity.Client;

public class TypeCurstomer :BaseEntity
{
	[Key]
	public int TypeCustomerId { get; set; }
	[Required]
	public string TypeCustomerDescripcion { get; set; } = null!;


	public IEnumerable<Customer> Customers { get; set; } = null!;
}

