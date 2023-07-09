using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configuration;

public class BodegaConfiguration : IEntityTypeConfiguration<Bodega>
{
    public void Configure(EntityTypeBuilder<Bodega> builder)
    {
        builder.ToTable("Bodega");

        builder.Property(p => p.IdBodega)
        .HasAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
        .HasMaxLength(3);

        builder.Property(p => p.NameBodega)
        .IsRequired()
        .HasMaxLength(50);

        builder.HasOne(p=> User)
        .WithMany(p => p.Bodegas)
        .HasForeignKey(p => p.IdBodega);
    }
}