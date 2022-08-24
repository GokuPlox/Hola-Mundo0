using reseña;
namespace producto;
public class Producto 
{
    public Producto (string nombre, float precio)
    {
        this.Nombre=nombre;
        this.Precio=precio;
       
        this.Reseñas=new List<Reseña>();
        
    }
    public float Precio {get; set;}
    public string Nombre {get; set;}
    public List<Reseña> Reseñas {get; set;}


}