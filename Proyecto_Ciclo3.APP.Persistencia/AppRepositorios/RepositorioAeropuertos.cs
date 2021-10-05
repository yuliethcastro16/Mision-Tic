using System.Collections.Generic;
using Proyecto_Ciclo3.App.Dominio;
using System.Linq;
using System;
 
namespace Proyecto_Ciclo3.App.Persistencia.AppRepositorios
{
    public class RepositorioAeropuertos
    {
        List<Aeropuertos> Aeropuertos;
        
    public RepositorioAeropuertos()
        {
            Aeropuertos= new List<Aeropuertos>()
            {
                new Aeropuertos{id=1,nombre="Audi",ciudad="xxxx",pais= "Colombia",coord_x= 4,coord_y= 23},
                new Aeropuertos{id=2,nombre="Toyota",ciudad="yyyyy",pais= "Colombia",coord_x= 16,coord_y= 45},
                new Aeropuertos{id=3,nombre="Mazda",ciudad="nnnnn",pais= "Colombia",coord_x= 24,coord_y= 34}
 
            };
        }
 
        public IEnumerable<Aeropuertos> GetAll()
        {
            return Aeropuertos;
        }
 
        public Aeropuertos GetAeropuertosWithId(int id){
            return Aeropuertos.SingleOrDefault(b => b.id == id);
        }

        public Aeropuertos Update(Aeropuertos newAeropuerto){
            var aeropuerto= Aeropuertos.SingleOrDefault(b => b.id == newAeropuerto.id);
            if(aeropuerto != null){
                aeropuerto.nombre = newAeropuerto.nombre;
                aeropuerto.ciudad = newAeropuerto.ciudad;
                aeropuerto.pais = newAeropuerto.pais;
                aeropuerto.coord_x = newAeropuerto.coord_x;
                aeropuerto.coord_y = newAeropuerto.coord_y;
            }
        return aeropuerto;
        }

        
        public Aeropuertos Create(Aeropuertos newAeropuerto)
        {
           if(Aeropuertos.Count > 0){
           newAeropuerto.id=Aeropuertos.Max(r => r.id) +1; 
            }else{
               newAeropuerto.id = 1; 
            }
           Aeropuertos.Add(newAeropuerto);
           return newAeropuerto;
        }

             
        public Aeropuertos Delete(int id)
        {
          var aeropuerto= Aeropuertos.SingleOrDefault(b => b.id == id);
          Aeropuertos.Remove(aeropuerto);
          return aeropuerto;
        }


    }
}
