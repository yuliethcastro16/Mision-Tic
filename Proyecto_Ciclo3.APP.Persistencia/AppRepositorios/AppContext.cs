using Microsoft.EntityFrameworkCore;
using Proyecto_Ciclo3.App.Dominio;
 
namespace Proyecto_Ciclo3.App.Persistencia
{
    public class AppContext: DbContext{
        public DbSet<Aviones> Aviones { get; set; }
        public DbSet<Aeropuertos> Aeropuertos { get; set; }
        public DbSet<Rutas> Rutas { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder){
            if(!optionsBuilder.IsConfigured){
                optionsBuilder.UseSqlServer("Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = ProyectoCiclo3Aviones");
            }
        }
    }
}
