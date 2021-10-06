using System.Collections.Generic;
using Proyecto_Ciclo3.App.Dominio;
using System.Linq;
using System;
 
namespace Proyecto_Ciclo3.App.Persistencia.AppRepositorios
{
    public class RepositorioAeropuertos
    {
        List<Aeropuertos> Aeropuertos;
        private readonly AppContext _appContext = new AppContext();   

        public IEnumerable<Aeropuertos> GetAll()
        {
           return _appContext.Aeropuertos;
        }
 
        public Aeropuertos GetAeropuertosWithId(int id){
            return _appContext.Aeropuertos.Find(id);
        }

        public Aeropuertos Create(Aeropuertos newAeropuerto)
        {
          var addAeropuerto = _appContext.Aeropuertos.Add(newAeropuerto);
            _appContext.SaveChanges();
            return addAeropuerto.Entity;
        }

        public Aeropuertos Update(Aeropuertos newAeropuerto){
            var aeropuerto = _appContext.Aeropuertos.Find(newAeropuerto.id);
            if(aeropuerto != null){
                aeropuerto.nombre = newAeropuerto.nombre;
                aeropuerto.ciudad = newAeropuerto.ciudad;
                aeropuerto.pais = newAeropuerto.pais;
                aeropuerto.coord_x = newAeropuerto.coord_x;
                aeropuerto.coord_y = newAeropuerto.coord_y;
                _appContext.SaveChanges();

            }
        return aeropuerto;
        }

          
        public void Delete(int id)
        {
        var aeropuerto = _appContext.Aeropuertos.Find(id);
        if (aeropuerto == null)
            return;
        _appContext.Aeropuertos.Remove(aeropuerto);
        _appContext.SaveChanges();  
        }


    }
}
