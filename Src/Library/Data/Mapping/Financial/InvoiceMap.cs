using Data.Schema;
using Entity.Financial;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data.Mapping.Financial;

public class InvoiceMap : IEntityTypeConfiguration<Invoice>
{
    public void Configure(EntityTypeBuilder<Invoice> builder)
    {
        builder.ToTable("Invoice", DataBaseSchema.Financial)
            .HasKey(x => x.InvoiceId);
    }
}

