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
    public class DetailsAvionModel : PageModel
    {
       private readonly RepositorioAviones repositorioAviones;
              public Aviones Avion {get;set;}
 
        public DetailsAvionModel(RepositorioAviones repositorioAviones)
       {
            this.repositorioAviones=repositorioAviones;
       }
 
        public IActionResult OnGet(int avionId)
        {
                Avion=repositorioAviones.GetAvionesWithId(avionId);
                return Page();
 
        }
    }
}
