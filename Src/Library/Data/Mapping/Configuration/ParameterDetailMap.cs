using System;
using Data.Schema;
using Entity.Configuration;
using Entity.Financial;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data.Mapping.Configuration
{
	public class ParameterDetailMap : IEntityTypeConfiguration<ParameterDetail>
    {
        public void Configure(EntityTypeBuilder<ParameterDetail> builder)
        {
            builder.ToTable("ParameterDetail", DataBaseSchema.Financial)
                .HasKey(x => x.ParameterDetailId);
        }
    }
}

