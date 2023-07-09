using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configuration;

public class ProductoConfiguration : IEntityTypeConfiguration<Producto>
{
    public void Configure(EntityTypeBuilder<Producto> builder)
    {
        builder.ToTable("Producto");

        builder.Property(p => p.IdProducto)
        .HasAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
        .HasMaxLength(3);

        builder.Property(p => p.NameProducto)
        .IsRequired()
        .HasMaxLength(50);

        builder.HasOne(p=> User)
        .WithMany(p => p.Productos)
        .HasForeignKey(p => p.IdProducto);
    }
}