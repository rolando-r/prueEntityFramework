using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configuration;

public class HistorialConfiguration : IEntityTypeConfiguration<Historial>
{
    public void Configure(EntityTypeBuilder<Historial> builder)
    {
        builder.ToTable("Historial");

        builder.Property(p => p.IdHistorial)
        .HasAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
        .HasMaxLength(3);

        builder.Property(p => p.IdHistorial)
        .IsRequired()
        .HasMaxLength(50);

        builder.HasOne(p => p.User)
        .WithMany(p => p.Historiales)
        .HasForeignKey(p => p.IdHistorial);

        builder.HasOne(p => p.Inventario)
        /* .WithMany(p => p.Historiales)
        .HasForeignKey(p => p.IdHistorial) */;

        builder.HasOne(p => p.Bodega)
        /* .WithMany(p => p.Historiales)
        .HasForeignKey(p => p.IdHistorial) */;
    }
}