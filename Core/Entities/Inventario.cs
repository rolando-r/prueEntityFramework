using System.ComponentModel.DataAnnotations;

namespace Core.Entities;
public class Inventario
{   
    public int IdInventario { get; set; }
    public int IdBodega { get; set; }
    public int IdProducto { get; set; }
    public int Cantidad { get; set; }
    public int CreatedBy { get; set; }
    public int UpdateBy { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
    public DateTime DeleteAt { get; set; }  
    public int IdUser { get; set; }
    public User User {get; set;}
    public Producto Producto { get; set; }
    public Bodega Bodega { get; set; }
}