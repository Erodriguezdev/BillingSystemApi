using System.ComponentModel.DataAnnotations;

namespace Entity.Financial;

public class TypeInvoice :BaseEntity
{
	[Key]
	public int TypeInvoiceId { get; set; }
	[Required]
	[StringLength(20)]
	public int TypeInvoiceDescripcion { get; set; }
}

