using System.ComponentModel.DataAnnotations;

namespace Entity.WareHouse
{
	public class Product : BaseEntity
	{
		[Key]
		public int ProductId { get; set; }
		[Required]
		[StringLength(50)]
		public string ProductCode { get; set; } = null!;
        [Required]
        [StringLength(150)]
		public string ProductName { get; set; } = null!;
        [Required]
        [StringLength(350)]
        public string ProductDescripcion{ get; set; } = null!;
		[Required]
		public decimal ProductPrice { get; set; }
		[Required]
        public int ProductQuantity { get; set; }

    }
}

