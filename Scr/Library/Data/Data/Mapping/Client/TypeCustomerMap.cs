
using Data.Schema;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Entity.Client;

namespace Data.Mapping.Client;

	public class TypeCustomerMap : IEntityTypeConfiguration<TypeCurstomer>
	{
    public void Configure(EntityTypeBuilder<TypeCurstomer> builder)
    {
        builder.ToTable("TypeCustomer", DataBaseSchema.Client)
            .HasKey(x => x.TypeCustomerId);
    }
}

