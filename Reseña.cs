namespace reseña;
public class Reseña 
{
    public Reseña (int calificacion, string comentario)
    {
        this.Calificacion=calificacion;
        this.Comentario=comentario;
    }
    public int? Calificacion {get ; set;}
    public string? Comentario {get; set;}
}