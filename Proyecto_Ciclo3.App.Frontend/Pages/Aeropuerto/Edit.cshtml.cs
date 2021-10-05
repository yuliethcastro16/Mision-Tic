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
    public class EditAeropuertoModel : PageModel
    {
       private readonly RepositorioAeropuertos repositorioAeropuertos;
              [BindProperty]
              public Aeropuertos Aeropuerto {get;set;}
 
        public EditAeropuertoModel(RepositorioAeropuertos repositorioAeropuertos)
       {
            this.repositorioAeropuertos=repositorioAeropuertos;
       }
 
        public IActionResult OnGet(int AeropuertoId)
        {
                Aeropuerto=repositorioAeropuertos.GetAeropuertosWithId(AeropuertoId);
                return Page();
 
        }
        public IActionResult OnPost()
        {
            if(!ModelState.IsValid)
            {
                return Page();
            }
            if(Aeropuerto.id>0)
            {
            Aeropuerto = repositorioAeropuertos.Update(Aeropuerto);
            }
            return RedirectToPage("./List");
        }

        
    }
}