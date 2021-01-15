using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MyWebLapTop.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyWebLapTop.Data.Configurations
{
    public class BantinConfiguration : IEntityTypeConfiguration<Bantin>
    {
        public void Configure(EntityTypeBuilder<Bantin> builder)
        {
            builder.ToTable("Bantins");

            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();
            builder.Property(x => x.Noidung).IsRequired().HasMaxLength(200);
        }
    }
}
