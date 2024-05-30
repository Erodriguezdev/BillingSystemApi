using System;
using Data.Schema;
using Entity.Configuration;
using Entity.Financial;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data.Mapping.Configuration
{
	public class ParameterMap : IEntityTypeConfiguration<Parameter>
    {
        public void Configure(EntityTypeBuilder<Parameter> builder)
        {
            builder.ToTable("Parameter", DataBaseSchema.Financial)
                .HasKey(x => x.ParameterId);
        }
    }
}

