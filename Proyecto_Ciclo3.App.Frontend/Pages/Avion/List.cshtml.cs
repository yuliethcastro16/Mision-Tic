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
    public class ListAvionModel : PageModel
    {
       
        private readonly RepositorioAviones repositorioAviones;
        public IEnumerable<Aviones> Aviones {get;set;}
        [BindProperty]
        public Aviones Avion {get;set;}
 
    public ListAvionModel(RepositorioAviones repositorioAviones)
    {
        this.repositorioAviones=repositorioAviones;
     }
 
    public void OnGet()
    {
        Aviones=repositorioAviones.GetAll();
    }
     public IActionResult OnPost()
        {
            if(Avion.id>0)
            {
                Avion = repositorioAviones.Delete(Avion.id);
            }
            
            return RedirectToPage("./List");
        }
    

    }
    
}
