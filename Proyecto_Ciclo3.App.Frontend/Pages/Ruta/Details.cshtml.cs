using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Proyecto_Ciclo3.App.Persistencia.AppRepositorios;
using Proyecto_Ciclo3.App.Dominio;
 
namespace Proyecto_Ciclo3.App.Frontend.Pages
{
    public class DetailsRutaModel : PageModel
    {
       private readonly RepositorioRutas repositorioRutas;
              public Rutas Ruta {get;set;}
 
        public DetailsRutaModel(RepositorioRutas repositorioRutas)
       {
            this.repositorioRutas=repositorioRutas;
       }
 
        public IActionResult OnGet(int rutaId)
        {
                Ruta=repositorioRutas.GetRutasWithId(rutaId);
                return Page();
 
        }
    }
}
