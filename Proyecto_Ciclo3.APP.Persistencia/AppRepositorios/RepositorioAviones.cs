using System.Collections.Generic;
using Proyecto_Ciclo3.App.Dominio;
using System.Linq;
using System;
 
namespace Proyecto_Ciclo3.App.Persistencia.AppRepositorios
{
    public class RepositorioAviones
    {
        List<Aviones> Aviones;
        private readonly AppContext _appContext = new AppContext();   

         public IEnumerable<Aviones> GetAll()
        {
           return _appContext.Aviones;
        }
 
        public Aviones GetAvionesWithId(int id){
            return _appContext.Aviones.Find(id);
        }
         public Aviones Create(Aviones newAvion)
        {
         var addAvion = _appContext.Aviones.Add(newAvion);
            _appContext.SaveChanges();
            return addAvion.Entity;

        }  
        public Aviones Update(Aviones newAvion){
            var avion = _appContext.Aviones.Find(newAvion.id);

            if(avion != null){
                avion.marca = newAvion.marca;
                avion.modelo = newAvion.modelo;
                avion.numero_asientos = newAvion.numero_asientos;
                avion.numero_baños = newAvion.numero_baños;
                avion.max_peso = newAvion.max_peso;
                _appContext.SaveChanges();
              
            }
        return avion;
        }
             
        public void  Delete(int id)
        {
        var avion = _appContext.Aviones.Find(id);
        if (avion == null)
            return;
        _appContext.Aviones.Remove(avion);
        _appContext.SaveChanges();
        }


    }
}
