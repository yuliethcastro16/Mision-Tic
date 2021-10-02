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
    public class EditAvionModel : PageModel
    {
       private readonly RepositorioAviones repositorioAviones;
              [BindProperty]
              public Aviones Avion {get;set;}
 
        public EditAvionModel(RepositorioAviones repositorioAviones)
       {
            this.repositorioAviones=repositorioAviones;
       }
 
        public IActionResult OnGet(int AvionId)
        {
                Avion=repositorioAviones.GetAvionesWithId(AvionId);
                return Page();
 
        }
        public IActionResult OnPost()
        {
            if(!ModelState.IsValid)
            {
                return Page();
            }
            if(Avion.id>0)
            {
            Avion = repositorioAviones.Update(Avion);
            }
            return RedirectToPage("./List");
        }

        
    }
}