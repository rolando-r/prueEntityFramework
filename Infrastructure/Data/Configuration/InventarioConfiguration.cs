using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configuration;

public class InventarioConfiguration : IEntityTypeConfiguration<Inventario>
{
    public void Configure(EntityTypeBuilder<Inventario> builder)
    {
        builder.ToTable("Inventario");

        builder.Property(p => p.IdInventario)
        .HasAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
        .HasMaxLength(3);

        builder.Property(p => p.IdInventario)
        .IsRequired()
        .HasMaxLength(50);

        builder.HasOne(p=> p.User)
        .WithMany(p => p.Inventarios)
        .HasForeignKey(p => p.IdInventario);

        builder.HasOne(p=> p.Producto)
        .WithMany(p => p.Inventarios)
        .HasForeignKey(p => p.IdInventario);

        builder.HasOne(p=> p.Bodega)
        /* .WithMany(p => p.Inventarios)
        .HasForeignKey(p => p.IdInventario) */;
    }
}