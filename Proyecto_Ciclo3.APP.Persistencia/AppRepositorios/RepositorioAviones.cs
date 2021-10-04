using System.Collections.Generic;
using Proyecto_Ciclo3.App.Dominio;
using System.Linq;
using System;
 
namespace Proyecto_Ciclo3.App.Persistencia.AppRepositorios
{
    public class RepositorioAviones
    {
        List<Aviones> Aviones;
 
    public RepositorioAviones()
        {
            Aviones= new List<Aviones>()
            {
                new Aviones{id=1,marca="Audi",modelo="xxxx",numero_asientos= 100000,numero_baños= 4,max_peso= 23},
                new Aviones{id=2,marca="Toyota",modelo="yyyyy",numero_asientos= 90000,numero_baños= 16,max_peso= 45},
                new Aviones{id=3,marca="Mazda",modelo="nnnnn",numero_asientos= 150000,numero_baños= 24,max_peso= 34}
 
            };
        }
 
        public IEnumerable<Aviones> GetAll()
        {
            return Aviones;
        }
 
        public Aviones GetAvionesWithId(int id){
            return Aviones.SingleOrDefault(b => b.id == id);
        }

        public Aviones Update(Aviones newAvion){
            var avion= Aviones.SingleOrDefault(b => b.id == newAvion.id);
            if(avion != null){
                avion.marca = newAvion.marca;
                avion.modelo = newAvion.modelo;
                avion.numero_asientos = newAvion.numero_asientos;
                avion.numero_baños = newAvion.numero_baños;
                avion.max_peso = newAvion.max_peso;
            }
        return avion;
        }

        
        public Aviones Create(Aviones newAvion)
        {
           if(Aviones.Count > 0){
           newAvion.id=Aviones.Max(r => r.id) +1; 
            }else{
               newAvion.id = 1; 
            }
           Aviones.Add(newAvion);
           return newAvion;
        }

             
        public Aviones Delete(int id)
        {
          var avion= Aviones.SingleOrDefault(b => b.id == id);
          Aviones.Remove(avion);
          return avion;
        }


    }
}
