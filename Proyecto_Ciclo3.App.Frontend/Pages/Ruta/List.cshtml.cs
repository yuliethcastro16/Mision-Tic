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
    public class ListRutaModel : PageModel
    {
        private readonly RepositorioRutas repositorioRutas;
        public IEnumerable<Rutas> Rutas {get;set;}
        [BindProperty]
        public Rutas Ruta {get;set;}
 
    public ListRutaModel(RepositorioRutas repositorioRutas)
    {
        this.repositorioRutas=repositorioRutas;
     }
        public void OnGet()
        {
         Rutas=repositorioRutas.GetAll();

        }
        public IActionResult OnPost()
        {
            if(Ruta.id>0)
            {
                 repositorioRutas.Delete(Ruta.id);
            }
            
            return RedirectToPage("./List");
        }
    }
}
