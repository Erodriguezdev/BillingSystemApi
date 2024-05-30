using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entity.Financial;

	public class InvoiceDetail : BaseEntity
	{
    [Key]
    public int InvoiceDetailId { get; set; }
    [Required]
    public int InvoiceId { get; set; }
    [Required]
    public int ProductId { get; set; }
    [Required]
    public decimal Price { get; set; }
    [Required]
    public decimal Quantity { get; set; }
    [Required]
    public decimal Tax { get; set; }
    [Required]
    public decimal Total { get; set; }

    [ForeignKey("InvoiceId")]
    public Invoice Invoice { get; set; } = null!;
}

