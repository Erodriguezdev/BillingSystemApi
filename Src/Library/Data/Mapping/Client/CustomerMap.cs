
using Data.Schema;
using Entity.Client;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data.Mapping.Client;

public class CustomerMap: IEntityTypeConfiguration<Customer>
	{
    public void Configure(EntityTypeBuilder<Customer> builder)
    {
        builder.ToTable("Customer", DataBaseSchema.Client)
            .HasKey(x => x.CustomerId);
    }
}

