using Data.Schema;
using Entity.WareHouse;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data.Mapping.WareHouse;

	public class ProductMap : IEntityTypeConfiguration<Product>
{
    public void Configure(EntityTypeBuilder<Product> builder)
    {
        builder.ToTable("Product", DataBaseSchema.WareHouse)
            .HasKey(x => x.ProductId);
    }
}

