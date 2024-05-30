using System.ComponentModel.DataAnnotations;

namespace Entity.Configuration;

public class ParameterDetail : BaseEntity
{
	[Key]
    public int ParameterDetailId { get; set; }

	[Required]
	[StringLength(200)]
	public string Value { get; set; } = null!;
}

