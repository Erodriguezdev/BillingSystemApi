using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entity.Financial;

public class Invoice
{
	[Key]
	public int InvoiceId { get; set; }
	[Required]
	public int InvoiceNumber { get; set; }
	[Required]
	public int TypeInvoiceId { get; set; }
	[Required]
	public int CustomerId { get; set; }
	[Required]
	public decimal Total { get; set; }
	[Required]
	public decimal TotalTax { get; set; }
	[Required]
	public decimal TotalBeforTax { get; set; }

	[ForeignKey("TypeInvoiceId")]
	public TypeInvoice TypeInvoice { get; set; } = null!;
	public IEnumerable<InvoiceDetail> InvoiceDetails { get; set; } = null!;
}

