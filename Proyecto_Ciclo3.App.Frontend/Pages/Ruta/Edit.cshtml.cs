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
    public class EditRutaModel : PageModel
    {
       private readonly RepositorioRutas repositorioRutas;
              [BindProperty]
              public Rutas Ruta {get;set;}
 
        public EditRutaModel(RepositorioRutas repositorioRutas)
       {
            this.repositorioRutas=repositorioRutas;
       }
 
        public IActionResult OnGet(int RutaId)
        {
                Ruta=repositorioRutas.GetRutasWithId(RutaId);
                return Page();
 
        }
        public IActionResult OnPost()
        {
            if(!ModelState.IsValid)
            {
                return Page();
            }
            if(Ruta.id>0)
            {
            Ruta = repositorioRutas.Update(Ruta);
            }
            return RedirectToPage("./List");
        }

        
    }
}