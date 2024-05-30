using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entity.Configuration;

public class ParameterDetail : BaseEntity
{
	[Key]
    public int ParameterDetailId { get; set; }

	[Required]
	public int ParameterId { get; set; }

	[Required]
	[StringLength(200)]
	public string Value { get; set; } = null!;

	[ForeignKey ("ParameterId")] 
	public Parameter Parameter { get; set; } = null!;
}

