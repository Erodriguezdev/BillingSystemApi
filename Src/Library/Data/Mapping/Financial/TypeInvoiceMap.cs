using Data.Schema;
using Entity.Financial;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data.Mapping.Financial;

public class TypeInvoiceMap : IEntityTypeConfiguration<TypeInvoice>
{
    public void Configure(EntityTypeBuilder<TypeInvoice> builder)
    {
        builder.ToTable("TypeInvoice", DataBaseSchema.Financial)
            .HasKey(x => x.TypeInvoiceId);
    }
}

