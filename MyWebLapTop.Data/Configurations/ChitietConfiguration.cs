using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MyWebLapTop.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyWebLapTop.Data.Configurations
{
    public class ChitietConfiguration : IEntityTypeConfiguration<Chitiet>
    {
        public void Configure(EntityTypeBuilder<Chitiet> builder)
        {
            builder.ToTable("Chitiets");

            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();

            builder.Property(x => x.Tieude).IsRequired().HasMaxLength(200);

            builder.Property(x => x.Noidung).IsRequired().HasMaxLength(5000);

            builder.Property(x => x.Lanxem).IsRequired().HasDefaultValue(0);
            builder.Property(x => x.Ngaydang).IsRequired();

            builder.HasOne(x => x.Bantin).WithMany(x => x.Chitiets).HasForeignKey(x => x.IdBantin);
        }
    }
}
