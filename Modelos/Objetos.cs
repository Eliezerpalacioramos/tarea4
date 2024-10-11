public enum TipoEntidad{
    Serie = 'S',
    Pelicula = 'P',
    Libro = 'L'

}

public class SeriePeliculalibro
{
    public int Id { get; set; }
    public string Nombre { get; set; } = "";
    public TipoEntidad Tipo {get; set;} = TipoEntidad.Serie;
    public string Pais { get; set; } = "";
    public string Idioma { get; set; } = "";
    public string FotoUrl { get; set; } = "";
    public string Resumen { get; set; } = "";


    public List<Personaje> Personajes { get; set; } = new List<Personaje>();
}

public class Personaje
{
    public int Id {get; set;}
    public string Nombre { get; set; } = "";
    public string Apodo { get; set; } = "";
    public string Raza { get; set; } = "";
    public string FotoUrl { get; set; } = "";
    public int Edad { get; set; }

    public string SignoZodiazal {get; set;} = "";
    public string PoderCaracteristico { get; set; } = "";

    public int SeriePeliculalibro {get; set;}
    public SeriePeliculalibro seriePeliculalibro {get; set;} = null!;
    
    
}