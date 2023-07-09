using System.Reflection;
using Core.Entities;
using Microsoft.EntityFrameworkCore;
namespace Infrastructure.Data;
public class PruebaEntityFrameworkContext : DbContext
{
    public PruebaEntityFrameworkContext(DbContextOptions<PruebaEntityFrameworkContext> options) : base(options)
    {
    }
    public DbSet<Bodega> Bodegas { get; set; }
    public DbSet<Historial> Historiales { get; set; }
    public DbSet<Inventario> Inventarios { get; set; }
    public DbSet<Producto> Productos { get; set; }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
    }
}