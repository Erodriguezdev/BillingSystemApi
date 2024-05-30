
using Data.Schema;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Entity.Client;

namespace Data.Mapping.Client;

	public class CustomerMap: IEntityTypeConfiguration<Customer>
	{
    public void Configure(EntityTypeBuilder<Customer> builder)
    {
        builder.ToTable("Customer", DataBaseSchema.Client)
            .HasKey(x => x.CustomerId);
    }
}

