using System.ComponentModel.DataAnnotations;

namespace Entity;

public class BaseEntity
{
	[Required]
	public bool Estatus { get; set;  }
	[Required]
	public DateTime Created { get; set; }
}

