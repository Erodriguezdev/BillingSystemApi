using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entity.Client;

public class Customer : BaseEntity
{
	[Key]
	public int CustomerId { get; set; }
	[StringLength(20)]
	public string? Acronyms { get; set; }
	[Required]
	[StringLength(150)]
	public string CustomerName { get; set; } = null!;
	[Required]
	public int TypeCustomerId { get; set; }

	[ForeignKey("TypeCustomerId")]
	public TypeCurstomer TypeCurstomer { get; set; } = null!;
	
    }

