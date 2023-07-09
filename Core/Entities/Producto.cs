using System.ComponentModel.DataAnnotations;

namespace Core.Entities;
public class Producto
{
    [Key]
    public int IdProducto { get; set; }
    public string ? NameProducto { get; set; }
    public string ? Description { get; set; }
    public int Estado { get; set; }
    public int CreatedBy { get; set; }
    public int UpdateBy { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
    public DateTime DeleteAt { get; set; }
    public User User { get; set; }
    public ICollection<Inventario> Inventarios { get; set; }
}