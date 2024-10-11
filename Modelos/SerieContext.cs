using Microsoft.EntityFrameworkCore;

public class SerieContext : DbContext
{
    public DbSet<SeriePeliculalibro> SeriePeliculalibros {get; set;} = null!;
    public DbSet<Personaje> Personajes {get; set;} = null!;


    public SerieContext(DbContextOptions<SerieContext> options) 
        : base(options) { }
    }
   
