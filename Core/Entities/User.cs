using System.ComponentModel.DataAnnotations;

namespace Core.Entities;
public class User
{
    [Key]
    public int IdUser { get; set; }
    public string ? NameUser { get; set; }
    public string ? Email { get; set; }
    public DateTime EmailVerified { get; set; }
    public int Estado { get; set; }
    public int CreatedBy { get; set; }
    public int UpdateBy { get; set; }
    public string ? Foto { get; set; }
    public string ? Password { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
    public DateTime DeleteAt { get; set; }
    public ICollection<Producto> Productos { get; set; }
    public ICollection<Inventario> Inventarios { get; set; }
    public ICollection<Historial> Historiales { get; set; }
    public ICollection<Bodega> Bodegas { get; set; }
}