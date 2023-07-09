using System.ComponentModel.DataAnnotations;

namespace Core.Entities;
public class Historial
{
    [Key]
    public int IdHistorial { get; set; }
    public int Cantidad { get; set; }
    public int IdBodegaOrigen { get; set; }
    public int IdBodegaDestino { get; set; }
    public int IdInventario { get; set; }
    public int CreatedBy { get; set; }
    public int UpdateBy { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
    public DateTime DeleteAt { get; set; }
    public User User { get; set; }
    public Inventario Inventario { get; set; }
    public Bodega Bodega { get; set; }
}