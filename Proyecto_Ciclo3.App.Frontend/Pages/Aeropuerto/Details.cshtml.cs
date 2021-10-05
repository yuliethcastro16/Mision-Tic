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
    public class DetailsAeropuertoModel : PageModel
    {
       private readonly RepositorioAeropuertos repositorioAeropuertos;
              public Aeropuertos Aeropuerto {get;set;}
 
        public DetailsAeropuertoModel(RepositorioAeropuertos repositorioAeropuertos)
       {
            this.repositorioAeropuertos=repositorioAeropuertos;
       }
 
        public IActionResult OnGet(int aeropuertoId)
        {
                Aeropuerto=repositorioAeropuertos.GetAeropuertosWithId(aeropuertoId);
                return Page();
 
        }
    }
}
