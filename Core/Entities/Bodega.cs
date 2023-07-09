using System.ComponentModel.DataAnnotations;

namespace Core.Entities;
public class Bodega
{
    [Key]
    public int IdBodega { get; set; }
    public string ? NameBodega { get; set; }
    public int IdResponsable { get; set; }
    public int Estado { get; set; }
    public int CreatedBy { get; set; }
    public int UpdateBy { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
    public DateTime DeleteAt { get; set; }
    public User User { get; set; }
    public object Inventario { get; set; }
    public object Inventarios { get; set; }
}