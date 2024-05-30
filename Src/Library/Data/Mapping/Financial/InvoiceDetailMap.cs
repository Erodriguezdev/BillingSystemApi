using Data.Schema;
using Entity.Financial;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data.Mapping.Financial;

public class InvoiceDetailMap : IEntityTypeConfiguration<InvoiceDetail>
{
    public void Configure(EntityTypeBuilder<InvoiceDetail> builder)
    {
        builder.ToTable("InvoiceDetail", DataBaseSchema.Financial)
            .HasKey(x => x.InvoiceDetailId);
    }
}

