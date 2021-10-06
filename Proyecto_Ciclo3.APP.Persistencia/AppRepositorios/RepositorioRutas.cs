using System.Collections.Generic;
using Proyecto_Ciclo3.App.Dominio;
using System.Linq;
using System;
 
namespace Proyecto_Ciclo3.App.Persistencia.AppRepositorios
{
    public class RepositorioRutas
    {
        List<Rutas> Rutas;
        private readonly AppContext _appContext = new AppContext();   


        public IEnumerable<Rutas> GetAll()
        {
           return _appContext.Rutas;
        }
 
        public Rutas GetRutasWithId(int id){
            return _appContext.Rutas.Find(id);
        }

        public Rutas Create(Rutas newRuta)
        {
            var addRuta = _appContext.Rutas.Add(newRuta);
            _appContext.SaveChanges();
            return addRuta.Entity;
        }

        public Rutas Update(Rutas newRuta){
            var ruta = _appContext.Rutas.Find(newRuta.id);
            if(ruta != null){
                ruta.origen = newRuta.origen;
                ruta.destino = newRuta.destino;
                ruta.tiempo_estimado = newRuta.tiempo_estimado;
                _appContext.SaveChanges();
            }
        return ruta;
        }
  
        public void Delete(int id)
        {
        var ruta = _appContext.Rutas.Find(id);
        if (ruta == null)
            return;
        _appContext.Rutas.Remove(ruta);
        _appContext.SaveChanges();
        }


    }
}

