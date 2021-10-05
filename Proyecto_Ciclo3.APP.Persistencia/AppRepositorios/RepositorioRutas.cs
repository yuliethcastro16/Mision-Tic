using System.Collections.Generic;
using Proyecto_Ciclo3.App.Dominio;
using System.Linq;
using System;
 
namespace Proyecto_Ciclo3.App.Persistencia.AppRepositorios
{
    public class RepositorioRutas
    {
        List<Rutas> Rutas;
 
    public RepositorioRutas()
        {
            Rutas= new List<Rutas>()
            {
                new Rutas{id=1,origen="Bogota",destino="Medellin",tiempo_estimado= "2 Horas"},
                new Rutas{id=2,origen="Medellin",destino="Cartagena",tiempo_estimado= "30 Minutos"},
                new Rutas{id=3,origen="Cucuta",destino="Bogota",tiempo_estimado= "1 hora"}
 
            };
        }
 
        public IEnumerable<Rutas> GetAll()
        {
            return Rutas;
        }
 
        public Rutas GetRutasWithId(int id){
            return Rutas.SingleOrDefault(b => b.id == id);
        }

        public Rutas Update(Rutas newRuta){
            var ruta= Rutas.SingleOrDefault(b => b.id == newRuta.id);
            if(ruta != null){
                ruta.origen = newRuta.origen;
                ruta.destino = newRuta.destino;
                ruta.tiempo_estimado = newRuta.tiempo_estimado;
               
            }
        return ruta;
        }

        
        public Rutas Create(Rutas newRuta)
        {
           if(Rutas.Count > 0){
           newRuta.id=Rutas.Max(r => r.id) +1; 
            }else{
               newRuta.id = 1; 
            }
           Rutas.Add(newRuta);
           return newRuta;
        }

             
        public Rutas Delete(int id)
        {
          var ruta= Rutas.SingleOrDefault(b => b.id == id);
          Rutas.Remove(ruta);
          return ruta;
        }


    }
}

